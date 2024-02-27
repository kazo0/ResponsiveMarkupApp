using Windows.Foundation;

namespace ResponsiveMarkupApp;

public sealed partial class MainPage : Page
{
	public MainPage()
	{
		this
			.Background(ThemeResource.Get<Brush>("ApplicationPageBackgroundThemeBrush"))
			.Content(new ResponsiveView()
				.NarrowTemplate(() => BuildContent(Colors.Green, "Narrow", 0))
				.NormalTemplate(() => BuildContent(Colors.Blue, "Normal", 90))
				.WideTemplate(() => BuildContent(Colors.Purple, "Wide", 180))
				.WidestTemplate(() => BuildContent(Colors.Orange, "Widest", 270))
			);
	}

	private static Grid BuildContent(Color bgColor, string title, double rotation) =>
		new Grid()
			.RowDefinitions("Auto,Auto")
			.Background(new SolidColorBrush(bgColor))
			.Children(
				new TextBlock()
					.Text(title)
					.FontSize(32),
				new Image()
					.Grid(row: 1)
					.Source("ms-appx:///ResponsiveMarkupApp/Assets/steve.png")
					.RenderTransformOrigin(new Point(0.5, 0.5))
					.RenderTransform(
						new RotateTransform()
							.Angle(rotation)
					)
					.Width(200)
			);
}
