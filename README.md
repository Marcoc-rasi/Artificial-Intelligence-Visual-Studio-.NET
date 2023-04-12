# Artificial-Intelligence-Visual-Studio-.NET

This repository is divided into two folders, I will start by explaining Eucladian-Hamming Distance and Triangle sum 9
This folder contains two projects “Animal classification by distance” and “Triangle”.

# Animal classification by distance

This project is used to classify animals, initially we are given two Excel files, the first contains animals classified according to certain characteristics, the second contains unclassified animals. The goal is to classify all the animals.
The program classifies based on two algorithms of the nearest neighbor, one is by Haming distance and the other by Euclidean distance. When running the program and classifying, you can decide which of the two methods will be used.
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

The most important projects are ClassificadorDeColoresPorEstadisticaClásica and ClasificadorDeColoresPorNeuronas. These projects have a high level of complexity and handle a large amount of information. Excel files are used to read and save information, which are located in the root of the project. It is necessary to change the path depending on your computer to be able to use the program.

These two projects recognize objects through their colors using an Arduino connected in series to Visual Studio with a TCS3200 color sensor. After starting the program, a sample is taken and the information of each color is saved and assigned to the name of the object. Then, the program recognizes the object by its color using classical statistics or perceptrons. The perceptron's parameters are calculated in real time and its training is recorded in an Excel file.

There are more projects in the folder that represent a large part of the statistical mathematical theory needed to learn AI, such as data normalization in the Gaussian bell and its respective graph. It's worth seeing them.
