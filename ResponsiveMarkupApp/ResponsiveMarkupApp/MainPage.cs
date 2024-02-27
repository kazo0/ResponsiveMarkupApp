namespace ResponsiveMarkupApp;

public sealed partial class MainPage : Page
{
	public MainPage()
	{
		this
			.Background(ThemeResource.Get<Brush>("ApplicationPageBackgroundThemeBrush"))
			.Content(new ResponsiveView()
				.NarrowTemplate(() => new Grid()
					.Background(new SolidColorBrush(Colors.Green))
					.Children(new TextBlock()
						.Text("Narrow")
						.FontSize(32)
					 )
				)
				.NormalTemplate(() => new Grid()
					.Background(new SolidColorBrush(Colors.Blue))
					.Children(new TextBlock()
						.Text("Normal")
						.FontSize(32)
					 )
				)
				.WideTemplate(() => new Grid()
					.Background(new SolidColorBrush(Colors.Purple))
					.Children(new TextBlock()
						.Text("Wide")
						.FontSize(32)
					 )
				)
				.WidestTemplate(() => new Grid()
					.Background(new SolidColorBrush(Colors.Orange))
					.Children(new TextBlock()
						.Text("Widest")
						.FontSize(32)
					 )
				)
			);
	}
}
