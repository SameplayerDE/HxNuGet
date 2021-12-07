public class TextureContentLoader : GenericContentLoader<string, Texture2D>
{
    public static TextureContentLoader Instance { get; } = new TextureContentLoader();

    static TextureContentLoader()
    {

    }

    private TextureContentLoader()
    {

    }

    public override void LoadContent(ContentManager contentManager)
    {
        Add("missing", contentManager.Load<Texture2D>("not_found"), true);
        Add("pixel", Graphics.Instance.GenerateTexture2D(1, 1, Color.White));
    }
}
