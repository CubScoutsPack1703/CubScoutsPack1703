namespace CubScoutsPack1703 {
	public class Program {
		public static void Main(string[] args) {
			var builder = WebApplication.CreateBuilder(args);
			var app = builder.Build();

			var options = new DefaultFilesOptions();
			options.DefaultFileNames.Clear();
			options.DefaultFileNames.Add("index.html");
			app.UseDefaultFiles(options);

			app.UseStaticFiles();

			//app.MapGet("/", () => "Hello World!");

			app.Run();
		}
	}
}