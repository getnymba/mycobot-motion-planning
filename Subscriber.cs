using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.MycobotCommunication;
using System;

public class Subscriber : MonoBehaviour
{
    public string topicName = "mycobot/angles_real";
    public ArticulationBody[] joint;  
    public float[] angle;

    void Start()
    {
        // start the ROS connection
       ROSConnection.GetOrCreateInstance().Subscribe<MycobotAnglesMsg>(topicName,AngleUpdate);
       this.angle = new float[6];
    }

    // Receive the message from server_endpoint.py running in ROS
    void AngleUpdate(MycobotAnglesMsg ma)
   {
        angle[0] = ma.joint_1;
        angle[1] = ma.joint_2;
        angle[2] = ma.joint_3;
        angle[3] = ma.joint_4;
        angle[4] = ma.joint_5;
        angle[5] = ma.joint_6;
   }

    // Update rotation in Unity
    void Update(){
        joint[0].transform.rotation = Quaternion.Euler(0,angle[0],0); 
        joint[1].transform.localRotation = Quaternion.Euler(90 + angle[1],0,-90);
        joint[2].transform.localRotation = Quaternion.Euler(0,angle[2],0);
        joint[3].transform.localRotation = Quaternion.Euler(0,90+angle[3],0);
        joint[4].transform.localRotation = Quaternion.Euler(-90+angle[4],0,-90);
        joint[5].transform.localRotation = Quaternion.Euler(angle[5],0,90);
    }

}
