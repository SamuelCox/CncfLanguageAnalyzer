# CncfLanguageAnalyzer
A small console app to find the predominant language for each cncf landscape project.

I was surprised to find that the CNCF's landscape CSV export didn't include languages the project was written of. Of course this does not always apply, but I thought where it is possible to find, it would be interesting to see.

So this project looks up the CNCF project on github (if it can), and finds the language with the most amount of bytes, and makes a modified CSV file with that in.

## Getting the CSV ##
The csv export can be downloaded from [here](https://landscape.cncf.io/)

## Running ##
To run this, from the root of the directory of the solution use `dotnet run <input csv filename> <output csv filename> <github PAT>`
