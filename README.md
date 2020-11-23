OpenCV in UE4
=============

[<img align="right" src="https://raw.github.com/Brandon-Wilson/OpenCV-Plugin/master/Plugins/OpenCV/Resources/Icon128.png" width="128" height="128"/>](https://raw.github.com/Brandon-Wilson/OpenCV-Plugin/master/Plugins/OpenCV/Resources/Icon128.png)
A tutorial on how to integrate the OpenCV library into UE4. Adaptation of the Plugin from [Brandon-Wilson](https://github.com/Brandon-Wilson/OpenCV-Plugin).

Instructions
----------
To use OpenCV in an Unreal Engine 4 project:

* Copy and merge all folders into an existing project's root directory. This project will need source code so that it looks in the binaries folder for the OpenCV libraries. If you don't have any source code, open the editor and add c++ source in the file menu.

* Regenerate project files (for visual studios, right click your project (.uasset) file and select 'generate visual studio project files' after deleting your previous visual studios file)

* Add the "OpenCV" public module dependency in project Build.cs (see PROJECTNAME.Build.cs)

* Add library dependencies to module or project Build.cs (see MODULENAME.Build.cs)

For an in-depth description of the plugin, please see the [tutorial.](https://wiki.unrealengine.com/Integrating_OpenCV_Into_Unreal_Engine_4)

License
=======

Licensed under the BSD License. Please see the LICENSE file included with the plugin's source code.