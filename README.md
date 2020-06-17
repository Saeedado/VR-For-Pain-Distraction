<h1>Prerequisites</h1>
<p>The following hardware is required:</p>
<p>1. Oculus Quest Headset</p>
<p>2. Oculus Touch Controllers</p>

<p></p>

<p>Please ensure you have the following software installed on your system:</p>
<p>1.	Unity Hub v2.2.2</p>
<p>2.	Unity Version 2019.3.0f3 or higher</p>
<p>3.	Have a Unity account with a valid licence.</p>
<p>4.	Git</p>
<p>5.	Oculus app on a smartphone</p>
<p>6.	Oculus account which is connected to your Oculus Quest.</p>

<h1>Downloading Relevant Files</h1>
<p>The project files can be downloaded via Strathclyde’s Gitlab by cloning the repository by using the following command in the folder you wish to contain the files:</p>
<p>git clone https://gitlab.cis.strath.ac.uk/hsb16145/vrforpaindistraction.git</p>

<h1>Setting Up Unity Project</h1>
<p>Once the relevant files have been imported, we need to set up the Unity project. To do this several steps have to be followed.</p>
<p>•	Open Unity Hub</p>
<p>•	Press the “ADD” button in the “Projects section in Unity Hub</p>

<img src="images/1.png" width ="600">
<p>•	Once this has been done, locate the folder where the relevant project files have been stored and click “Select Folder”.</p>
<img src="images/2.png" width ="600">

<p>•	This will create a project file in Unity Hub with the corresponding file name.</p>
<img src="images/3.png" width ="600">

<p>•	Select this file within Unity Hub by left clicking on the project name, this will start creating the project inside unity. This may take a few minutes.</p>
<h1>Building the Project on the Oculus Quest</h1>
<p>Once the project is open in Unity, we need to switch the deployment platform to android. To do this go to:</p>
<p>•	File</p>
<p>•	Build Settings</p>
<p>•	Click on Android</p>
<img src="images/4.png" width ="600">

<p>•	Click Switch Platform</p>
<p>•	This may take a few minutes or longer. While waiting, power on your Oculus Quest device, which is connected to the app on your smartphone</p>
<p>•	Open the smart phone app</p>
<img src="images/5.png" width ="300">

<p>•	Click “Settings” in the bottom right corner</p>
<img src="images/6.png" width ="200">

<p>•	Click on “More Settings”</p>
<img src="images/7.png" width ="200">

<p>•	Click on “Developer Mode”</p>
<img src="images/8.png" width ="200">

<p>•	Activate “Developer mode” by clicking on the slider</p>
<p>•	Once Unity has finished switching platform from PC to Android</p>
<p>•	Connect your Oculus Quest to your PC using an appropriate connector.</p>
<p>•	Then put on your Oculus Quest headset, you will be met with a message saying whether you would like to enable USB debugging, Select Yes.</p>
<img src="images/9.png" width ="600">

<p>•	Press “Build and Run”</p>
<p>•	This will build the device on the Oculus Quest and run it.</p>
<p>If you wish to access the application within the Oculus Quest device instead of getting Unity to run it for you follow the following steps:</p>
<p>•	Point and press the trigger button your Oculus Touch Controller to select menu options</p>
<p>•	Select the library</p>
<img src="images/10.png" width ="600">

<p>•	Then Select “Unknown Sources”</p>
<img src="images/11.png" width ="600">
<p>•	Select your project’s name</p>
<img src="images/12.png" width ="600">

<p>•	This will launch the application.</p>

<h1>Maintenance</h1>
<p>All files that are used in the actual environment are stored in the “Assets” Folder.</p>
<img src="images/13.png" width ="600">
<p>If you need to edit anything about the project itself, the relevant assets will be stored in the assets folder, such as scenes, scripts, prefabs and textures.</p>
<img src="images/14.png" width ="600">

<p>Scripts are available in Assets > Scripts. To find scripts relating a specific environment, navigate to the relevant folder.</p>
<img src="images/15.png" width ="600">

<p>Double click on the script you wish to edit, this will open it in the IDE you have set up in Unity, by default, Visual Studio will be opened if you installed it with Unity, otherwise you will have to go to the project settings to change this to IDE you wish to work with, however Visual Studio is highly recommended as it comes with built in support with Unity. </p>
