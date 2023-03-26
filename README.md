<p align="center">
<img src="https://raw.githubusercontent.com/Founderroni/Assets/main/Images/Kaffee.png">
</p>

# Kaffee Utility
Kaffee utility is an open source injector and multi-tool for MCBE. It features client injection, custom dll injection, ID (CID, DID and MCID) spoof, and more.


## FAQ
* Why is it not launching?
    1. You might need to install the latest [Dotnet Framework](https://dotnet.microsoft.com/en-us/download/dotnet-framework)

* Where is the data stored (DLLs and such)
    1. They are stored in "C:\Users\YOURUSER\AppData\Local\FadedSolutions\Kaffee" - You could also press the folder icon inside the app to automatically open up file explorer to that directory.

* Does it support version X.XX?
    1. The Client Injector will support whatever version the client supports. If it doesn't support the version you're using then you'll have to wait for an update by the client owner.
    2. Spoofer will support the version it says, you can check the pointer list in my [Asset](https://github.com/founderroni/assets) repo to see what versions Spoofer supports.

* How can I contribute?
    1. If you want to contribute to the repo you may create a pull request.
    2. If you want to update the pointers for the spoofer you can open a pull request in my [Asset](https://github.com/founderroni/assets) repo.

* How do I build the solutions?
    1. Download the solutions as a zip, extract all its contents into a folder, double click the .sln to open the solution in Visual Studio (you should have this installed), Set the Confguration Manager values to "Release" and "x64", then build the project.

* What is the difference between "Handlers" and "Utils'?
    1. Handlers are made for specific tasks and are generally used only in one tab, though there are exceptions.
    2. Utils has functions that are used in multiple places and making coding easier.

* What Nuget Packages are used?
    1. [memory.dll by erfg12](https://github.com/erfg12/memory.dll) - Used for the spoofer and memory patcher
    2. [Guna.Ui2](https://gunaui.com/) - Used for the GUI
    3. [Config.Net](https://github.com/aloneguid/config) - Used for Configs/Settings
    4. [Costura.Fody](https://github.com/Fody/Costura) - Used to package all the DLLs into the exe
    5. [Tulpep.NotificationWindow](https://github.com/Tulpep/Notification-Popup-Window) - Used for popup notifications
    6. [dot-net-transitions](https://github.com/UweKeim/dot-net-transitions) - Used for animations

## Credits
* [EchoHackCMD](https://github.com/EchoHackCmd) - Injection Method
* [Yeemi](https://github.com/Laamy) - MMR (MinecraftMemoryReader)