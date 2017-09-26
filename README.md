# **Important**
This is an old version. Please go to its [new repository](https://github.com/Onetimetwotimes/Blenderbot/)

# Blender Discord Notify
This project, currently codenamed "BlenderBot", is a standalone application that will start a render and notify you when it finishes.
# Usage
If you would like to use this tool, download the [installer](https://www.dropbox.com/s/oxhcea2mcetfufx/BlenderBot-Setup.msi?dl=1)
## Configuration
In order to make use of this tool, you need to configure it. The following is an overview of the settings:
### Main Dialog:
| Option | Meaning |
| --- | --- |
| File | The name of the .blend you would like to render (do not include extension). |
| Frame | Which frame to render (usually 1). |
| Shutdown? | Whether or not you want your computer to shut down once it has finished rendering (you will still be notified). |

### Preferences:
| Option | Meaning |
| --- | --- |
| Blender Executable | Location of blender.exe. **Must be configured on first use** |
| Projects Folder | Location of your projects folder (you have one right?). Basically the location of your .blend files. **Must be configured on first use** |
| Channel Id | The ID # of the Discord Channel you want the notification to be sent to. (See below for instructions on setting up notifications)

## Discord:
In order for you to be notified, you need to do the following:

1. [Add "BlenderBot" to your Discord Channel and allow it to send messages](https://discordapp.com/oauth2/authorize?&client_id=323891647739985920&scope=bot&permissions=0)
2. Configure the application with a channel ID <details> 
    <summary>Walkthrough with images</summary>
    Copy your channel's ID <br>
    <img src="http://i.imgur.com/UdwvjuZ.png" /> <br>
    Paste into "Channel Id" in the application's "Preferences" dialog <br>
    <img src="http://i.imgur.com/JRJahOq.png" /> <br>
  </details>
  
  # Notes
  ## Known Issues:
  
  Bad aesthetics. I know, refer to my catch phrase (I'm working on it).
  
  ## Planned Features:
  
  Animations support
  
  Graphical improvements
