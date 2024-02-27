namespace ResponsiveMarkupApp;

public sealed partial class MainPage : Page
{
	public MainPage()
	{
		this
			.Background(ThemeResource.Get<Brush>("ApplicationPageBackgroundThemeBrush"))
			.Content(new ResponsiveView()
				.NarrowTemplate(() => BuildContent(Colors.Green, "Narrow"))
				.NormalTemplate(() => BuildContent(Colors.Blue, "Normal"))
				.WideTemplate(() => BuildContent(Colors.Purple, "Wide"))
				.WidestTemplate(() => BuildContent(Colors.Orange, "Widest"))
			);
	}

	private static Grid BuildContent(Color bgColor, string title) =>
		new Grid()
			.Background(new SolidColorBrush(bgColor))
			.Children(new TextBlock()
				.Text(title)
				.FontSize(32)
			);
}
