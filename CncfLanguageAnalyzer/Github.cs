using Octokit;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CncfLanguageAnalyzer
{
    public class Github
    {
        private readonly GitHubClient _githubClient;

        public Github(string token)
        {
            var creds = new Credentials(token);
            _githubClient =  new GitHubClient(new ProductHeaderValue("CncfLanguageAnalyzer"));
            _githubClient.Credentials = creds;
        }

        public async Task<string> GetMostUsedLanguageForRepo(string repoLink)
        {
            var ownerAndName = repoLink.Replace("https://github.com", string.Empty).Split("/", StringSplitOptions.RemoveEmptyEntries);
            try
            {
                var languages = await _githubClient.Repository.GetAllLanguages(ownerAndName[0], ownerAndName[1]);

                var language = languages.Aggregate(new RepositoryLanguage(), (currentLang, accumulator) =>
                {
                    if (currentLang.NumberOfBytes > accumulator.NumberOfBytes)
                    {
                        return currentLang;
                    }
                    return accumulator;
                }).Name;
                return language;
            }
            catch
            {
                // Data in cncf export is bad, probably the repo has been re-named since they added the data, just ignore it.
                return null;
            }
        }
    }
}
