namespace LocationSlugger
{
    public class LocationSlugUtility : ILocationSlugUtility
    {
        /// <summary>
        /// Takes a location string and turns it into a url friendly 'slug'
        /// </summary>
        /// <param name="stringLocation"></param>
        public string Slug(string stringLocation)
        {
            return stringLocation
                .Replace("-", "~")
                .Replace(", ", "--")
                .Replace(" ", "-");
        }

        /// <summary>
        /// Takes a slugged location and returns a title friendly version
        /// </summary>
        /// <param name="sluggedLocation"></param>
        public string UnSlug(string sluggedLocation)
        {
            return sluggedLocation
                .Replace("--", ", ")
                .Replace("-", " ")
                .Replace("~", "-");
        }
    }
}