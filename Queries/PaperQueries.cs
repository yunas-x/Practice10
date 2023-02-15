using System;
using System.Collections.Generic;
using System.Text;
using Practice_10_Example.Papers;

namespace Practice_10_Example.Queries
{
    public static class PaperQueries
    {
        /// <summary>
        /// Defines named papers in the given collection of papers
        /// </summary>
        /// <param name="papers">Array of Paper-typed variables (incl. descendants)</param>
        /// <returns>
        /// Array of booleans where every value corresponds the respective paper in the input <br/>
        /// Returns null if imput is null or empty
        /// </returns>
        public static bool[] QueryFindNamedPapers(Paper[] papers)
        {
            if (AreNullOrEmpty(papers))
                return null;

            var result = new bool[papers.Length];

            for (int i = 0; i < papers.Length; i++)
            {
                result[i] = papers[i].IsPaperNamed();
            }

            return result;
        }

        /// <summary>
        /// Get number of papers issued for all time
        /// </summary>
        /// <returns>Number of papers</returns>
        public static int QueryGetNumberOfPapers() => Paper.GetPaperCount();

        /// <summary>
        /// Get book authors
        /// </summary>
        /// <param name="papers">Array of books</param>
        /// <returns>For each book returns author if it exists, else "no author"</returns>
        public static string[] QueryGetBookAuthors(Paper[] papers)
        {
            if (AreNullOrEmpty(papers))
                return null;

            var authors = new string[papers.Length];

            for (int i = 0; i < papers.Length; i++)
            {
                Book book = papers[i] as Book;

                authors[i] = (book is null || !book.HasAuthor()) ? "No author" : book.Author;
            }

            return authors;
        }

        /// <summary>
        /// Defines if paper collection is null or empty
        /// </summary>
        /// <param name="papers">List of papers</param>
        /// <returns>True if null or empty, otherwise false</returns>
        private static bool AreNullOrEmpty(Paper[] papers) => papers is null || papers.Length == 0;
    }
}
