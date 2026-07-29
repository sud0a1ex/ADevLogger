<h1 align="center">ADevLogger</h1>
<p align="center"><b>Simple DevLog Writer for your DEVLOG.md</b></p><br>
<div align="center">
  <img style="height: 200px;" src="https://github.com/sud0a1ex/ADevLogger/blob/master/ADevLogger/Captures/capture_editor_0.png" alt="Editor">
  <img style="height: 200px;" src="https://github.com/sud0a1ex/ADevLogger/blob/master/ADevLogger/Captures/capture_create_project.png" alt="Create Project Window">
  <img style="height: 200px;" src="https://github.com/sud0a1ex/ADevLogger/blob/master/ADevLogger/Captures/capture_editor_2.png" alt="Editor">
</div>
<p align=center><i>Captures of ADevLogger</i></p><br>
<h2 align="center">Story of ADevLogger</h2>
<p><b>Have you ever been inspired to create something by a movie?</b> It all started because of a movie named "The Social Network." I was watching that movie when I was inspired by the blogging scene.
I thought the concept of coding and telling people what you're doing is actually so cool. And there are several ways to do so, such as blogging on a website, telling a friend, or posting it on social media. But I thought, well, how about I just create a file in my repo and write to it directly? That's when I discovered something called "DevLog" or "Development Log". I'm pretty sure tech enthusiasts know what that means. From my understanding, it's basically a diary where developers share updates about the project. Then my idea was to create a markdown file for my devlog and write it in a specific way. This consists of the number of log, time and date, topic, and the content of that topic. I figured that copying and pasting just isn't it.<br><br>
That's when I decided to spend my free time and created ADevLogger. A desktop app that will generate my devlog with the exact format that I want. You can change the format as you like too! Because it's open-source, of course.
</p><hr>
<h2>Quick Guides</h2>
<h3>Default Format</h3>
<pre>Log {log_count} - [ @HH:MM:SS MM/DD/YYYY]<br>Topic: {topic_name}<br><br>{content}</pre>
<p>Format can be changed in the source code :)</p>
<h3>New Project</h3>
<ol>
  <li>Click "New Project" button.</li>
  <li>Enter your project name, which will be used as the file name. (file extension will be .dlog)</li>
  <li>Select a directory path where you want the project file to be by clicking the "Select Directory" button.</li>
  <li>Select a Markdown(.md) file you want to edit by clicking the "Select Markdown" button.</li>
  <li>Click "Create" to create the project file! If it works, a message box should pop up in no time.</li>
  <li>Lastly, close the "New Project" window and go back to the first window. Then, click the "Open Project" button and select the project file you just created!</li>
</ol>
<p>Congratulations! You just created a project.</p>
<h3>Open Project</h3>
<p>Quick guide for this one.<br>Just click "Open Project" button and select ADevLogger project file. The file extension must be ".dlog".<br>If the file is actually written correctly or created by ADevLogger itself, then there shouldn't be a problem and the "File Path" labels will be loaded.</p>
<h3>Can't Open Project</h3>
<p>I don't know what you did or what I did to achieve this. But we'll go through this together.</p>
<ol>
  <li>Open ADevLogger project file(.dlog) with a text editor.</li>
  <li>Check if the format is correct:<br>
  <pre>log:{log_count}<br>markdown:{your_markdown_file_path}</pre>
  <b>Very important!</b> Make sure there are only two lines.</li>
  <li>Check if your Markdown file exists and the path is typed correctly.</li>
</ol>
<p>I hope these solutions can help you. I apologize in advance in case these solutions don't work.</p>
<h3>How To Start?</h3>
<p>ADevLogger has only 6 things to work with!</p>
<ol>
  <li>"Log Count" label: At the top, used for telling your latest log count.</li>
  <li>"Topic" text box: Name of the topic.</li>
  <li>"Content" text box: The content of that topic.</li>
  <li>"Current Log" text box on the right: This one just tells you how your devlog will be looking after you press "Save."</li>
  <li>"Add Log" button: Adds the new log with log count, time and date, topic, and content to the markdown. Will be shown in the "Current Log" text box.</li>
  <li>"Save" button: Saves the changes you made.<br><b>Don't forget to press save! I actually forgot to press save during testing and I had to rewrite my logs again.</b></li>
</ol>
<h3>Cloning Repository(git)</h3>
<p>.NET 10 will be required for this project.</p>
<pre><code>git clone https://github.com/sud0a1ex/ADevLogger.git</code></pre>
<hr>
<h2>Future Plans</h2>
<ul>
  <li>Customizable format in app</li>
</ul>
