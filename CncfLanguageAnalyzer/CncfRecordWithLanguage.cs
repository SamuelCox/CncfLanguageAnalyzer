namespace CncfLanguageAnalyzer
{
    public class CncfRecordWithLanguage : CncfRecord
    {
        public string Languages { get; set; }

        public static CncfRecordWithLanguage Create(CncfRecord record)
        {
            return new CncfRecordWithLanguage
            {
                Name = record.Name,
                Organization = record.Organization,
                Homepage = record.Homepage,
                Logo = record.Logo,
                Twitter = record.Twitter,
                CrunchbaseURL = record.CrunchbaseURL,
                MarketCap = record.MarketCap,
                Ticker = record.Ticker,
                Funding = record.Funding,
                Member = record.Member,
                Relation = record.Member,
                License = record.License,
                Headquarters = record.Headquarters,
                LatestTweetDate = record.LatestTweetDate,
                Description = record.Description,
                CrunchbaseDescription = record.CrunchbaseDescription,
                CrunchbaseHomepage = record.CrunchbaseHomepage,
                CrunchbaseRegion = record.CrunchbaseRegion,
                CrunchbaseCity = record.CrunchbaseCity,
                CrunchbaseCountry = record.CrunchbaseCountry,
                CrunchbaseTwitter = record.CrunchbaseTwitter,
                CrunchbaseLinkedin = record.CrunchbaseLinkedin,
                CrunchbaseTicker = record.CrunchbaseTicker,
                CrunchbaseKind = record.CrunchbaseKind,
                CrunchbaseMinEmployees = record.CrunchbaseMinEmployees,
                CrunchbaseMaxEmployees = record.CrunchbaseMaxEmployees,
                Category = record.Category,
                Subcategory = record.Subcategory,
                OSS = record.OSS,
                GithubRepo = record.GithubRepo,
                GithubContributorsCount = record.GithubContributorsCount,
                GithubContributorsLink = record.GithubContributorsLink,
                GithubDescription = record.GithubDescription,
                GithubLatestCommitDate = record.GithubLatestCommitDate,
                GithubLatestCommitLink = record.GithubLatestCommitLink,
                GithubReleaseDate = record.GithubReleaseDate,
                GithubReleaseLink = record.GithubReleaseLink,
                GithubStars = record.GithubStars,
                GithubStartCommitDate = record.GithubStartCommitDate,
                GithubStartCommitLink = record.GithubStartCommitLink,

            };
        }

    
    }
}
