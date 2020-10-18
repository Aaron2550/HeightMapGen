[![Codacy Badge](https://app.codacy.com/project/badge/Grade/2cf58825ac87454b98b7401872067a89)](https://www.codacy.com/gh/Aaron2550/HeightMapGen/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=Aaron2550/HeightMapGen&amp;utm_campaign=Badge_Grade)

# HeightMapGen
A height map generator with GUI which generates you a height map with corrosponding blend map.  
***Ignore the german commit titles, Visual Studio likes to just push out a commit without asking me what the title should be.***

## Requirements
This requires .NET Framework 4.7.2 and a display (duh) unless ... you manage to use it without the GUI ... i guess?

## Limitations
Technically, the biggest possible height map one could generate with the [OpenSimplex2](https://github.com/KdotJPG/OpenSimplex2) library would be  
1.79769313486232 E308 pixels by 1.79769313486232 E308 pixels big.  *Why would you need it any bigger?*

Generating a 2048x2048 height map with 8 octaves using the smooth library, took about 25 seconds.  
The resulting image took up around 6 MiB on the hard drive, while generating the program will used around 85 MiB of RAM.

## Screenshots
### GUI
![Screenshot of the GUI](https://stronghold.host/media/dqCdyDpf.png "Screenshot")  
### Result
![The resulting Image](https://stronghold.host/media/gISOvjCE.png "Result")

*Blend map generation is not yet implemented.*

## License
You can do whatever the heck you want with this code. But rather than making your own better version,  
i'd be happy if you just open a pull request to improve upon my cursed code.

This uses a slightly modified version of the [OpenSimplex2](https://github.com/KdotJPG/OpenSimplex2) library by [K.JPG](https://github.com/KdotJPG).
*(It's only been modified to make codacy shut up about it having bad code)*
