# _At-Risk Animals_

#### June 18th, 2020

#### By _**Julia Seidman, Nitun Datta, Nathan Watkins-Hoagland and Eric Settels**_

## Description

_This application is an educational site focused on endangered and vulnerable animals in North America. The site was
created using C#/.Net. The UI makes use of SVG files for interactive maps. Users can view a set of animals for each
country (US, Mexico & Canada), and then select an individual animal to view details. Information primarily comes from
the IUCN RedList API._

_This application is meant to be viewed in the browser. It will need a .NET Core Sdk 3.1 or 2.2 & ASP.Net 3.1 or 2.2
download._

## Setup/Installation Requirements

_Make sure you have [git version control](https://git-scm.com/downloads) installed on your computer._

1. Click the green 'Clone or Download' button and copy the link / download the zip
2. Open terminal and type... or skip to #4 if you downloaded the zip

**Windows**

```sh
cd desktop
```

Mac & linux

```sh
cd ~/Desktop
```

3.  in terminal type '_git clone {link to repository}_ '

```sh
git clone {link to repository}
```

4. If you downloaded the zip then extract all onto your desktop
5. Open the folder with VSC or an equivalent
6. Install .NET Core using
   <a href="https://docs.microsoft.com/en-us/dotnet/core/install/runtime?pivots=os-windows">this</a> link
7. Then Run the code below in the terminal to confirm installation

```sh
dotnet -- version
```

8. In the terminal enter to confirm the proper version installed

```sh
dotnet tool install -g
dotnet-script
```

9. Download _[ASP.NET Core](https://dotnet.microsoft.com/download)_ To enable live viewing on a local server
10. You will need to create a file in the root directory of the project run in powershell

```sh
new-item appsettings.json
```

11. Open project, navigate to the containing folder of the project & Run the code below to confirm build stability

```sh
dotnet run build
```

12. Within that same containing folder Run _dotnet watch run_ To open a live server w/auto updated viewing

13. Enjoy

## Specs

### Behavior Driven Development Spec List

#### At-Risk Animals

|                                              Behavior                                               |                       Input                       |          Output          |
| :-------------------------------------------------------------------------------------------------: | :-----------------------------------------------: | :----------------------: |
| The user can view a map of North America and get info about the biomes of the 3 component countries |              'http://localhost:5001/              | 'Map with hovering text' |
|                     The user can POST data sheets about animlas at the shelter                      |     'http://localhost:5000/{shelter}{animal}'     | 'Populate a data sheet'  |
|                            The user can view whats avalible for adoption                            |     'http://localhost:5000/{shelter}{animal}'     |    'List of animals'     |
|                                      The user Edit the animals                                      |  'http://localhost:5000/{shelter}{animal}{PUT}'   |      'Edits animal'      |
|                                  The user can DELETE an animal bio                                  | 'http://localhost:5000/{shelter}{animal}{DELETE}' |      'Deletes bio'       |

---

## Known Bugs

_N/A_ - 6/18/2020

## GitHub / gh-pages

https://github.com/juliaseid/EndangeredAnimals

WiseFool92.github.io/EndangeredAnimals

## Support

_Email: watkins92@gmail.com_

_Email: settels.eric@gmail.com_

---

## Built With

- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1)
- [IUCN Red List of Threatened Species API](https://apiv3.iucnredlist.org/api/v3/docs)

## Useful tools

- [free icons @ icons8](https://icons8.com/)
- [free icons @ fontawesome](https://fontawesome.com/)

---

- [Old School Gifs Search](https://gifcities.org/)
- [free images @ unsplash](https://unsplash.com/)

  - **_source.unsplash.com_ will return a random image at a desired size by simply calling the size after the url
    followed by a '?' and a keyword. Example below**

  - _https://source.unsplash.com/400x400/?cat_
  - http://unsplash.it/500/500 - This will just return a random image the size of 500x500

---

- [Flex-box Cheat Sheet](http://yoksel.github.io/flex-cheatsheet/)
- [CSS Grid Cheat Sheet](http://grid.malven.co/)

---

- [CSS Gradient BG Generator](https://mycolor.space/gradient)
- [CSS Basic Gradient Generator](https://cssgradient.io/)

---

- [CSS Dropshadow Generator](https://cssgenerator.org/box-shadow-css-generator.html)

### License

This project is licensed under the MIT License

Copyright (c) 2020 **_Nathan Watkins-Hoagland, Eric Settels, Julis Seidman, Nitun Datta_**
