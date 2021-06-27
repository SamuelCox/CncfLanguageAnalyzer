using CsvHelper.Configuration.Attributes;

namespace CncfLanguageAnalyzer
{
    public class CncfRecord
    {
        public string Name { get; set; }
        public string Organization { get; set; }
        public string Homepage { get; set; }
        public string Logo { get; set; }
        public string Twitter { get; set; }
        [Name("Crunchbase URL")]
        public string CrunchbaseURL { get; set; }
        [Name("Market Cap")]
        public object MarketCap { get; set; }
        public string Ticker { get; set; }
        public object Funding { get; set; }
        public string Member { get; set; }
        public string Relation { get; set; }
        public string License { get; set; }
        public string Headquarters { get; set; }
        [Name("Latest Tweet Date")]
        public string LatestTweetDate { get; set; }
        public string Description { get; set; }
        [Name("Crunchbase Description")]
        public string CrunchbaseDescription { get; set; }
        [Name("Crunchbase Homepage")]
        public string CrunchbaseHomepage { get; set; }
        [Name("Crunchbase City")]
        public string CrunchbaseCity { get; set; }
        [Name("Crunchbase Region")]
        public string CrunchbaseRegion { get; set; }
        [Name("Crunchbase Country")]
        public string CrunchbaseCountry { get; set; }
        [Name("Crunchbase Twitter")]
        public string CrunchbaseTwitter { get; set; }
        [Name("Crunchbase Linkedin")]
        public string CrunchbaseLinkedin { get; set; }
        [Name("Crunchbase Ticker")]
        public string CrunchbaseTicker { get; set; }
        [Name("Crunchbase Kind")]
        public string CrunchbaseKind { get; set; }
        [Name("Crunchbase Min Employees")]
        public object CrunchbaseMinEmployees { get; set; }
        [Name("Crunchbase Max Employees")]
        public object CrunchbaseMaxEmployees { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public string OSS { get; set; }
        [Name("Github Repo")]
        public string GithubRepo { get; set; }
        [Name("Github Stars")]
        public object GithubStars { get; set; }
        [Name("Github Description")]
        public string GithubDescription { get; set; }
        [Name("Github Latest Commit Date")]
        public string GithubLatestCommitDate { get; set; }
        [Name("Github Latest Commit Link")]
        public string GithubLatestCommitLink { get; set; }
        [Name("Github Release Date")]
        public string GithubReleaseDate { get; set; }
        [Name("Github Release Link")]
        public string GithubReleaseLink { get; set; }
        [Name("Github Start Commit Date")]
        public string GithubStartCommitDate { get; set; }
        [Name("Github Start Commit Link")]
        public string GithubStartCommitLink { get; set; }
        [Name("Github Contributors Count")]
        public object GithubContributorsCount { get; set; }
        [Name("Github Contributors Link")]
        public string GithubContributorsLink { get; set; }
    }

}
