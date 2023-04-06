# Artificial-Intelligence-Visual-Studio-.NET

This repository is divided into two folders, I will start by explaining Eucladian-Hamming Distance and Triangle sum 9
This folder contains two projects “Animal classification by distance” and “Triangle”.

# Animal classification by distance

This project is used to classify animals, initially we are given two Excel files, the first contains animals classified according to certain characteristics, the second contains unclassified animals. The goal is to classify all the animals.
The program classifies based on two algorithms, one is by Haming distance and the other by Euclidean distance. When running the program and classifying, you can decide which of the two methods will be used.
When the information is classified, it is stored in Excel files and stored in the folders "Hamming Distance" and "Euclidean Distance"
It is possible that the program fails if the access paths to the initial Excel documents are not modified, or to the folders mentioned above, it is recommended to change the addresses manually, videos that explain the operation of the program have also been added.

# The triangle

It is a riddle that is solved by placing the numbers from 1 to 6, in a triangle made of circles, three per side, without repeating numbers. Each side of the triangle must add up to 9.
This program does not use Excel files so it can compile without problems, for the solution of the puzzle, design an algorithm capable of solving this problem regardless of the start number, the description of the algorithm is in a document inside the folder. There are also videos explaining how the program works.

# The second folder - neural networks.

All the projects are inside a single project called “Base Project”, they can be started individually, but it is recommended to open the “Base Project.sln” inside the folder to be able to work with the projects in a more comfortable way.

# Exodo
One of the main pieces of the projects is the “Exodo” library, it contains all the necessary methods in a standard “math” library, such as abs, sum, ceiling, cos, sin, etc., the difference is that I I added extra power by being able to receive arrays of the type, [ ], [ , ] as arguments. It also has more sections: functions, gauss, line, and statistics, they are methods that contain all the mathematical-statistical material necessary to manage your database in the form of arrays, and to be able to store them, as well as graph them. You can feel free to extract this library from the project and use it to your advantage in any other project.

# ClassificadorDeColores

The next most important projects would be ClassificadorDeColoresPorEstadisticaClásica and ClasificadorDeColoresPorNeuronas, these have a high level of complexity, but I assure you that if you manage to run it you will see why.
The amount of information that is handled here is large, so Excel files were used to read and save information, these files are generally found in the root of the project \Artificial Intelligence\Neural Networks\Base Project\ColorByNeuronClassifier\bin\Debug you must change the path depending on your computer to be able to use the program.

These two projects recognize between objects through their colors, an Arduino connected in series to visual studio was used, the Arduino contained a TCS3200 color sensor which returns three measurements R,G,B. After starting the program, a sample is made with the program interfaces and saves the information of each color and assigns it to the name of the object. The next thing is to recognize the object if it is A or B by its color, samples are taken and the program says which object is the one that is presented in front of the color sensor, one project recognizes the color by classical statistics, the other by perceptrons .
All the characteristics of a perceptron are defined within its class, and it has access to all the methods within the EXODO library, its parameters are calculated in real time as well as its training, this training is recorded in an Excel file within the folder mentioned above, where you can see each of the attributes of the perceptron as well as a representation of it, and also all the samples that make up your training, that is, what are the R,G,B data recorded from the object.
There are more projects in the folder, these correspond to mini-projects that can be used to represent a large part of the statistical mathematical theory that is needed to learn AI, such as data normalization in the Gaussian bell and its respective graph, it is worth seeing them.
