#include <bits/stdc++.h>
#include <windows.h>
#include <GL/glut.h> // GLUT, include glu.h and gl.h
using namespace std;
void display() {

     glClearColor(0.408f, 0.816f, 1.02f, 0.0f);
    glClear(GL_COLOR_BUFFER_BIT); // Clear the color buffer (background)
    gluOrtho2D(-10, 10, -10, 10);
     int x1,x2,y1,y2,x,y;
     cout<< "enter the value x1:"<<endl;
     cin>>x1;
     cout<< "enter the value x2:"<<endl;
     cin>>x2;
     cout<< "enter the value y1:"<<endl;
     cin>>y1;
     cout<< "enter the value y2:"<<endl;
     cin>>y2;

     float mod = (y2-y1)/(x2-x1);
     cout<<"mod"<<endl;
     ///do not need to take mode as a user input because we are calculating the value of mode
     //cin>>mod;

     glPointSize(4.0f);
     /// If we want to see the full line then just change the name of "GL_POINTS" to "GL_LINES"
     glBegin(GL_POINTS);

             if (mod == 1)
                {
                    x = x1;
                    y = y1;
                    while (x <= x2)
                    {
                        glVertex2f(x++, y++);
                    }
                }


                else if (mod < 1)
                 {
                    float y = y1;
                    x = x1;
                    while (x <= x2)
                    {
                        glVertex2f(x++, round(y));
                        y = y+mod;
                    }
                 }


             else {
                    float x = x1;
                    y = y1;
                    while (y <= y2)
                    {
                        glVertex2f(round(x), y++);
                        x = x+ (1 / mod);
                    }
                }
     glEnd();
    glFlush();

}

int main(int argc, char** argv) {
    glutInit(&argc, argv);
    glutInitWindowSize(400,400); // Set the window's initial width & height
    glutInitWindowPosition(50,50);  // Set the window's initial position according to the monitor
    glutCreateWindow("DDA"); // Create a window with the given title
    glutDisplayFunc(display); // Register display callback handler for window re-paint
    glutMainLoop(); // Enter the event-processing loop
    return 0;
}
