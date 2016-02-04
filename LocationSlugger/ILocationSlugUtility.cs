namespace LocationSlugger
{
    public interface ILocationSlugUtility
    {
        string Slug(string stringLocation);

        string UnSlug(string sluggedLocation);
    }
}