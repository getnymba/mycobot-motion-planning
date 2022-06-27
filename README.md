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

1.1) Once Unity is installed, open package manager, and add ROS-TCP-ENDPOINT, URDF-IMPORTER from the git link.

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

1.2) After installing packages, download and import mycobot.unitypackage from Releases as custom assets.

[OPTIONAL] 1.3) In ROS settings menu, change ip address of ROS (if using VM)

## ROS Side

2.1) To build ROS package, run the following command in command line.

```
$ mkdir ~/catkin_ws
$ cd ~/catkin_ws
$ git clone https://github.com/getnymba/mycobot-motion-planning
$ catkin_make
$ source ~/catkin_ws/devel/setup.bash
$ sudo echo 'source ~/catkin_ws/devel/setup.bash' >> ~/.bashrc
```
Reference: https://github.com/elephantrobotics/mycobot_ros

2.2) Run ROSLaunch

```
$ roslaunch mycobot_communication communication_topic.launch
```

## Motion Planning

3.1) Start player in Unity.

3.2) Change Values of Goal_angle of Subscriber script in firefighter gameobject.

Demo: https://youtu.be/Phar-wUFfHU
