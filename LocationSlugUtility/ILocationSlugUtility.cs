namespace AlexJamesBrown.LocationSlugUtility
{
    public interface ILocationSlugUtility
    {
        string Slug(string stringLocation);

        string UnSlug(string sluggedLocation);
    }
}