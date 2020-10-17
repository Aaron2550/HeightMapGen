# HeightMapGen
A height map generator with GUI which generates you a height map with corrosponding blend map.  
***Ignore the german commit titles, Visual Studio likes to just push out a commit without asking me what the title should be.***

## Requirements
This requires .NET Framework 4.7.2 and a display (duh) unless... you manage to use it wihtout the GUI ... i guess?

## Limitations
Technically, the biggest possible height map one could generate with the [OpenSimplex2](https://github.com/KdotJPG/OpenSimplex2) library would be  
1.79769313486232 E308 pixels by 1.79769313486232 E308 pixels big.  *Why would you need it any bigger?*

When generating a 2048x2048 height map, the resulting image will take up around 6.14 MiB on your hard drive,  
while generating the program will use around 230 MiB of RAM.


## Screenshots
### GUI
![Screenshot of the GUI](https://stronghold.host/media/Ol85VTbj.png "Screenshot")  
### Result
![The resulting Image](https://stronghold.host/media/DFz5pSul.png "Result")

*Blend map generation is not yet implemented.*

## License
You can do whatever the heck you want with this code. But rather than making your own better version,  
i'd be happy if you just open a pull request to improve upon my cursed code.

This uses the [OpenSimplex2](https://github.com/KdotJPG/OpenSimplex2) library by [K.JPG](https://github.com/KdotJPG).
