namespace LocationSlugger
{
    public interface ILocationSlugger
    {
        string Slug(string stringLocation);

        string UnSlug(string sluggedLocation);
    }
}