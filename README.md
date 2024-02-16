# 3D-Graph
This is a demo of a 3D graph created in Unity to represent the Vector3 position of an object. It is testable with the block in the scene. 

When the blocks position is changed, the graph will update with the new position values. This can be changed to have different values for the y-axis, but time will stay consistent. The graph is capable of recording and displaying the position value up to 5 seconds. It updates in real-time and is made for live data to update it. 

When testing, please enter play mode then move the block in scene view. The graph is not made for values that are outside of the range of (-5, 5) for the y-axis value. When, the value is outside of that range it will display outside of the graph. Another limitation is that quick changes in the position do not display as well and require more data points. It can also be expanded to have more data points as the script was created to update an unlimited amount of points. The time value that the points update at will need to be altered when adding more points as the time the data is recorded will increase with added points and is given by time range = data points * time point updates. 
