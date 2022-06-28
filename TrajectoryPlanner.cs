using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.MycobotCommunication;

public class TrajectoryPlanner : MonoBehaviour
{
    ROSConnection ros;
    public string topicName = "mycobot/angles_goal";
    public float[] goal_angle;

    // Publish the myCobot's rotation every N seconds
    public float publishMessageFrequency = 0.5f;

    // Used to determine how much time has elapsed since the last message was published
    private float timeElapsed;

    void Start()
    {
        // start the ROS connection
        ros = ROSConnection.GetOrCreateInstance();
        ros.RegisterPublisher<MycobotSetAnglesMsg>(topicName);
    }

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > publishMessageFrequency)
        {
             var data = new MycobotSetAnglesMsg();
        
            data.joint_1 = goal_angle[0];
            data.joint_2 = goal_angle[1];
            data.joint_3 = goal_angle[2];
            data.joint_4 = goal_angle[3];
            data.joint_5 = goal_angle[4];
            data.joint_6 = goal_angle[5];
            data.speed = 100;

            // Finally send the message to server_endpoint.py running in ROS
            ros.Publish(topicName, data);

            timeElapsed = 0;
        }
    }
}