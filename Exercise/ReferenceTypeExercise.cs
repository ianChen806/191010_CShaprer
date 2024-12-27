using FluentAssertions;

namespace Exercise;

public class ReferenceTypeExercise
{
    [Fact]
    public void Test()
    {
        var appSettings = new AppSettings { Theme = "Light", Language = "English" };

        var moduleA = new ModuleA();
        moduleA.ChangeTheme(appSettings, "Dark");
        moduleA.Settings.Theme.Should().Be("Dark");
        moduleA.Settings.Language.Should().Be("English");

        // 預期 moduleB 拿到預設的 appSettings 但是會在 DisplaySettings方法中修改Language
        var moduleB = new ModuleB();
        moduleB.DisplaySettings(appSettings);
        moduleA.Settings.Theme.Should().Be("Light");
        moduleA.Settings.Language.Should().Be("French");
    }

    private class ModuleA
    {
        public AppSettings Settings { get; set; }

        public void ChangeTheme(AppSettings settings, string newTheme)
        {
            Settings = settings;
            settings.Theme = newTheme;
        }
    }

    private class ModuleB
    {
        public AppSettings Settings { get; set; }

        public void DisplaySettings(AppSettings settings)
        {
            Settings = settings;
            settings.Language = "French";
        }
    }

    private class AppSettings
    {
        public string Theme { get; set; }

        public string Language { get; set; }
    }
}
