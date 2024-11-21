/*#include <bits/stdc++.h>
#include <windows.h>
#include <GL/glut.h>
using namespace std;

void display() {
    glClearColor(0.408f, 0.816f, 1.02f, 0.0f);
    glClear(GL_COLOR_BUFFER_BIT);
    gluOrtho2D(-10, 10, -10, 10);
    int x1, y1, x2, y2;
    cout << "Enter the value of x1: ";
    cin >> x1;
    cout << "Enter the value of y1: ";
    cin >> y1;
    cout << "Enter the value of x2: ";
    cin >> x2;
    cout << "Enter the value of y2: ";
    cin >> y2;

    glPointSize(4.0f);
    glBegin(GL_POINT);
   // glBegin(GL_LINES);
    int dx = x2 - x1;
    int dy = y2 - y1;
    int x = x1, y = y1;
    float D_start = 2 * dy - dx;
     float D_East = 2 * dy;
    float D_north_east = 2 * (dy - dx);

    /// This condition is for North_east

    if (D_start>0) {
        D_start = 2 * dx - dy;             // Initial decision parameter
        D_East = 2 * dx;                   // Case 1 adjustment
        D_north_east = 2 * (dx - dy);      // Case 2 adjustment

        while (y <= y2) {
            glVertex2f(x, y);               // Plot the current point
            if (D_start < 0) {             // Case 1: D_start < 0
                D_start = D_start + D_East;    // Update D_start
            } else {                           // Case 2: D_start >= 0
                D_start = D_start + D_north_east;    // Update D_start
                x = x + 1;                     // Increment x
            }
            y = y + 1;                         // Increment y
        }
    }
    ///this is for north_east
    else {
            while (x <= x2) {
            glVertex2f(x, y);                   // Plot the current point
            if (D_start < 0) {                  // Case 1: D_start < 0
                D_start = D_start + D_East;    // Update D_start
            } else {                          // Case 2: D_start > 0
                D_start= D_start + D_north_east;    // Update D_start
                y = y + 1;                   // Increment y
            }
            x = x + 1;                    // Increment x
        }


    }

    // Plot the final point
    glVertex2f(x2, y2);

    glEnd();
    glFlush();
}

int main(int argc, char** argv) {
    glutInit(&argc, argv);
    glutInitWindowSize(400, 400);
    glutInitWindowPosition(50, 50);
    glutCreateWindow("Bresenham's Line");
    glutDisplayFunc(display);
    glutMainLoop();
    return 0;
}*/

#include <bits/stdc++.h>
#include <windows.h>
#include <GL/glut.h> // GLUT, include glu.h and gl.h
using namespace std;

void display() {
    glClearColor(0.408f, 0.816f, 1.02f, 0.0f); // Background color
    glClear(GL_COLOR_BUFFER_BIT);             // Clear the buffer
    gluOrtho2D(-10, 10, -10, 10);             // Set coordinate system

    int x1, y1, x2, y2;
    cout << "Enter the value of x1: ";
    cin >> x1;
    cout << "Enter the value of y1: ";
    cin >> y1;
    cout << "Enter the value of x2: ";
    cin >> x2;
    cout << "Enter the value of y2: ";
    cin >> y2;

    glPointSize(4.0f); // Set point size
    glBegin(GL_POINTS);

    // Step 1: Calculate Δx and Δy
    int dx = x2 - x1;
    int dy = y2 - y1;

    // Step 2: Initialize decision parameter
    int d= 2*dy-dx;
    int dE= 2*dy;
    int dNE= 2*(dy - dx);

    int x = x1, y = y1; // Starting point

    // Step 3: Bresenham's Algorithm
    while (x <= x2) 
        {
        glVertex2f(x, y); // Plot the current point

        if (d < 0) 
        {
            // Case: Choose E (East)
            d = d + dE; // Update decision parameter
        } else {
            // Case: Choose NE (North-East)
            d = d + dNE; // Update decision parameter
            y = y + 1;   // Increment y
        }
        x = x + 1; // Increment x
    }

    glEnd();
    glFlush();
}

int main(int argc, char** argv) {
    glutInit(&argc, argv);
    glutInitWindowSize(400, 400);        // Set the window's initial width & height
    glutInitWindowPosition(50, 50);      // Set the window's initial position
    glutCreateWindow("Bresenham's Line"); // Create a window with the given title
    glutDisplayFunc(display);            // Register display callback handler
    glutMainLoop();                      // Enter the event-processing loop
    return 0;
}









