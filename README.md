
# Hand Gesture Project


Welcome to ML.Net Hand Gesture
The project use ML.Net and Hand Gesture Recognition Database from this [kaggle repository](https://www.kaggle.com/gti-upm/leapgestrecog)  based on Leap Motion Sensor. The Database is a collection of near-infra-red images of ten distinct hand gestures. In this notebook we use end-to-end deep learning to build a classifier for these images.

![alt Hand Gesture](https://github.com/mrcarbook/handgesture/blob/master/HandGestureML.WebApp/wwwroot/CameraPhotos/dataset-cover.png)

We use [ML.Net Model Builder](https://dotnet.microsoft.com/apps/machinelearning-ai/ml-dotnet/model-builder) to build Machine Learning Model to recognize Gesture Hand.

Below some picture of Model Builder Wizard with only 3 steps we build a image classification model. Before to start, download and unzip on file system [the Hand Gesture Database](https://www.kaggle.com/benenharrington/hand-gesture-recognition-database-with-cnn/data)

![alt Data](https://github.com/mrcarbook/handgesture/blob/master/Model%20Training/data.PNG)

2) Create new .Net core project and start the wizard of Model Builder and select the data folder 
![alt Data](https://github.com/mrcarbook/handgesture/blob/master/Model%20Training/datapreview.PNG)

3) Start the traing, the dataset is about 20.000 images.
![alt Data](https://github.com/mrcarbook/handgesture/blob/master/Model%20Training/train.PNG)

4) Finaly evaluate and test it
![alt Data](https://github.com/mrcarbook/handgesture/blob/master/Model%20Training/evalute.PNG)

Finaly I created a web app project to take snapshot with webcam and use the machine learning model to recognize the gesture.

![alt Data](https://github.com/mrcarbook/handgesture/blob/master/Model%20Training/prediction.PNG)


Next step, I'm working on the machine learning model in order to improve! Keep you update!
