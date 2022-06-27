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

![demo]([https://www.notion.so/signed/https%3A%2F%2Fs3-us-west-2.amazonaws.com%2Fsecure.notion-static.com%2F4e79be41-142c-4aa3-b46b-84a765e55651%2FUnity_Mycobot.mp4?id=2e2c11f6-224a-48b7-8bd5-82aed9126ea8&table=block&spaceId=d5d16523-63c3-4dae-9099-e8adb29b5820&name=Unity%20Mycobot.mp4&userId=8ac9ce9c-3ae1-4955-a340-2f2d88603f48&cache=v2](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/4e79be41-142c-4aa3-b46b-84a765e55651/Unity_Mycobot.mp4?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220627%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220627T174858Z&X-Amz-Expires=86400&X-Amz-Signature=0bef60b15c35a3881ee419964a3e57b111494a7d7022078970471efc52facdf2&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Unity%2520Mycobot.mp4%22&x-id=GetObject))
