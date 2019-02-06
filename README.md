# Snowbooks-CSharp
The Snowbooks server converted from Java to C#

### How It Works
The server opens a socket on the defined port and waits for connections from the client. The client makes a connection every time it wants
to transmit data and the server is always ready to process it. Once the data is processed the connection diminishes.

### Features
- Offers a simple console JavaFX application that can easily take in new commands. Currently only 1 command is useful.
- Processes packets in a multi-threaded fashion.
- Stores active users and their current ip.
- Stores User accounts using serialization.

### My Experience
As I was building my portfolio I noticed I hadn't show cased any of my knowledge in languages and frameworks outside of Java. Although I have a publish Unity3D game I felt like I needed more. I converted my Java server to a C# server that will connect with the Java client to show I have a solid understanding of how to program in multiple languages.


