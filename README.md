# myCobot Motion Planning in Unity 

**Notes**:

<!-- This is the mycobot motion planning package written by Nyambayar D.([getnymba@gmail.com]()) -->

* Make sure that `Atom` is flashed into the top Atom and `Transponder` is flashed into the base Basic.
* Supported ROS versions:
   * Ubuntu 16.04 / ROS Kinetic
   * Ubuntu 18.04 / ROS Melodic
   * Ubuntu 20.04 / ROS Noetic
   
## Build Instructions
### Unity Side

Once Unity is installed, open package manager, and add ROS-TCP-ENDPOINT, URDF-IMPORTER from the git link.

To load a package from a Git URL:

Click the add button in the status bar.

The options for adding packages appear.

 ![alt text](https://docs.unity3d.com/uploads/Main/upm-ui-giturl.png)

Select Add package from git URL from the add menu. A text box and an Add button appear.

Enter a Git URL in the text box and click Add.

  ```
  https://github.com/Unity-Technologies/ROS-TCP-Connector.git?path=/com.unity.robotics.ros-tcp-connector
  ```
  
  ```
  https://github.com/Unity-Technologies/URDF-Importer.git?path=/com.unity.robotics.urdf-importer
  ```
