### Generating meta tags for basic properties

Initialize an instance of class `OpenGraphProperties` and fill out the basic properties:
```C#
OpenGraphProperties og = new OpenGraphProperties {
    SiteName = "MySite",
    Title = "A page about something - MySite",
    Type = "website",
    Url = "http://mysite.example.org/a-page-about-something/",
    Description = "A quick description about the page, that will be shown when sharing the page on services like Facebook."
};
```

Then in your MVC view (or somewhere similar), you can simply write:

```HTML
<!DOCTYPE html>
<html lang="en">
<head>
  <title>A page about something - MySite</title>
  @og
</head>
</html>
```

This will generate the following HTML:

```HTML
<!DOCTYPE html>
<html lang="en">
<head>
  <title>A page about something - MySite</title>
  <meta property="og:title" content="A page about something - MySite" />
  <meta property="og:site_name" content="MySite" />
  <meta property="og:url" content="http://mysite.example.org/a-page-about-something/" />
  <meta property="og:type" content="website" />
  <meta property="og:description" content="A quick description about the page, that will be shown when sharing the page on services like Facebook." />
</head>
</html>
```





### How about some images? Videos too?

The Open Graph protocol also describes images, videos and audio. Skybrud.OpenGraph has several ways of adding an image or a video. Audio is not supported yet, but will be coming soon.

The `OpenGraphProperties` class has a property called `Media` of the type `OpenGraphMediaCollection`. This class lets you add instances of `OpenGraphMedia` that will be a part of the generated HTML. `OpenGraphMedia` is an abstract class currently only implemented by `OpenGraphImage` and `OpenGraphVideo`.

Here is a few examples on how to add an image using either `OpenGraphMediaCollection` or some o the "shortcut" methods in `OpenGraphProperties`:

```C#
og.AddImage(image.Url);
og.AddImage(image.Url, image.Width, image.Height);
og.Media.Add(new OpenGraphImage(image.Url));
og.Media.Add(new OpenGraphImage(image.Url, image.Width, image.Height));
```

And videos:

```C#
og.AddVideo("/vid/awesome.mp4");
og.AddVideo("/vid/awesome.mp4", 1920, 1080);
og.AddVideo(new OpenGraphVideo("/vid/awesome.mp4"));
og.AddVideo(new OpenGraphVideo("/vid/awesome.mp4", 1920, 1080));
```

If you for any reason wan't to clear or reset the media collection, you can do this by:

```C#
og.Media.Clear();
```






### Under the hood

The `OpenGraphProperties` class is the one should should deal with as a developer, but under the hood, `OpenGraphProperties` inherits from the class `OpenGraphObject`. This is where the magic happens.

`OpenGraphObject` then implements the `IHtmlString` interface. In short terms, this means that ASP.NET MVC will see instances of this class as a HTML string so you simply can print out the HTML by writing `@og`.

The generated HTML will consist of all properties that implement the `OpenGraphPropertyAttribute` attribute, so you can also extend the classes provided to fit your custom use cases.

If a property has the type of `IEnumerable<OpenGraphObject>` and has the `OpenGraphCollectionAttribute` attribute, objects in that collection will be printed out as well.
