#include <windows.h>
#include <GL/glut.h>
#include <stdlib.h>
#include <math.h>
void initGL() {
    glClearColor(1.0f, 1.0f, 1.0f, 1.0f); /// Main BG full white
}
/// This part is for only keyboard
float shipX = 0.0f; /// Initial X position of the ships
float shipY = 0.0f; /// Initial Y position of the ship
/// Circle function for sun
void drawCircle(float cx, float cy, float r) {
    glBegin(GL_POLYGON);
    for (int i = 0; i <= 360; i++) {
        float angle = i * 3.1416 / 180.0f; // Convert degrees to radians
        float x = r * cos(angle);         // Calculate x-coordinate
        float y = r * sin(angle);         // Calculate y-coordinate
        glVertex2f(cx + x, cy + y);       // Add vertex
    }
    glEnd();
}
/// Function to draw a main ship
void drawShip(float offsetX, float offsetY) {
    glPushMatrix();
    glTranslatef(offsetX + shipX, offsetY + shipY, 0.0f); /// Translate the ship based on offsets
    ///upper side
    glBegin(GL_POLYGON);
    glColor3ub(255, 0, 0); /// Red color
    glVertex2f(17,-20);
    glVertex2f(17,-22);
    glVertex2f(15,-22);
    glVertex2f(15,-24);
    glVertex2f(28,-24);
    glVertex2f(28,-22);
    glVertex2f(26,-22);
    glVertex2f(26,-20);
    glEnd();
    /// Lower side
    glBegin(GL_QUADS);
    glColor3ub(255, 0, 0); /// Red color
    glVertex2f(-0.5, -8.25);
    glVertex2f(31.25, -8.25);
    glVertex2f(31, -6);
    glVertex2f(2, -6);
    glEnd();
    /// Dark Blue Base
    glBegin(GL_POLYGON);
    glColor3ub(0, 0, 77); /// Dark blue color
    glVertex2f(-4, -12);
    glVertex2f(6, -12);
    glVertex2f(7, -11);
    glVertex2f(31.25, -11);
    glVertex2f(31.25, -8.25);
    glVertex2f(-0.5, -8.25);
    glEnd();
    ///Boxes
    glBegin(GL_POLYGON);
    glColor3ub(0,0,77);
    glVertex2f(3,-12);
    glVertex2f(3,-14.5);
    glVertex2f(3,-17);
    glVertex2f(13,-17);
    glVertex2f(13,-20);
    glVertex2f(17,-20);
    glVertex2f(29,-20);
    glVertex2f(29,-11);
    glVertex2f(7,-11);
    glVertex2f(6,-12);
    glEnd();
    glPopMatrix();
}

/// Function to draw the sun
void drawSun(float cx, float cy, float r) {
    glColor3f(1.0, 1.0, 0.0); /// Yellow color
    drawCircle(cx, cy, r);

    /// Draw the sun's rays
    glBegin(GL_LINES);
    for (int i = 0; i < 12; i++) { /// 12 rays
        float angle = 2.0f * M_PI * i / 12;
        float x1 = cx + cos(angle) * r;       /// Start of ray (edge of sun)
        float y1 = cy + sin(angle) * r;
        float x2 = cx + cos(angle) * (r + 0.3); /// End of ray (outside sun)
        float y2 = cy + sin(angle) * (r + 0.3);
        glVertex2f(x1, y1);
        glVertex2f(x2, y2);
    }
    glEnd();
}
void display() {
    glClear(GL_COLOR_BUFFER_BIT);
    ///Ground color
    glBegin(GL_POLYGON);
    glColor3ub(241,231,215);
    glVertex2f(-50,-26);
    glVertex2f(-5,5);
    glVertex2f(-50,5);
    glEnd();
    glBegin(GL_POLYGON);
    glColor3ub(241,231,215);
    glVertex2f(-50,5);
    glVertex2f(-5,5);
    glVertex2f(-5,39);
    glVertex2f(-50,39);
    glEnd();
    /// Draw Ships
    drawShip(0.0f, 0.0f);   /// Main ship
    drawShip(-10.0f, 20.0f);  /// Down ship
    drawShip(20.0f, -20.0f);/// Upper ship
    /// Sun
    drawSun(-43, -37, 3);
    glFlush();
}

/// Handle keyboard inputs for movement
void handleKeyboard(unsigned char key, int x, int y) {
    switch (key) {
    case 'w': // Move up
        shipY -= 1.0f;
        break;
    case 's': // Move down
        shipY += 1.0f;
        break;
    case 'a': // Move left
        shipX -= 1.0f;
        break;
    case 'd': // Move right
        shipX += 1.0f;
        break;
    case 27: // Escape key to exit
        exit(0);
    }
    glutPostRedisplay(); // Redraw the scene
}

/// Special keys (e.g., arrow keys)
void handleSpecialKeys(int key, int x, int y) {
    switch (key) {
    case GLUT_KEY_UP:
        shipY -= 1.0f;
        break;
    case GLUT_KEY_DOWN:
        shipY += 1.0f;
        break;
    case GLUT_KEY_LEFT:
        shipX -= 1.0f;
        break;
    case GLUT_KEY_RIGHT:
        shipX += 1.0f;
        break;
    }
    glutPostRedisplay(); // Redraw the scene
}

int main(int argc, char** argv) {
    glutInit(&argc, argv);
    glutInitWindowSize(1400, 800);
    glutInitWindowPosition(50,50);
    glutCreateWindow("Port");
    glutDisplayFunc(display);
    glutKeyboardFunc(handleKeyboard);   // Register keyboard handler
    glutSpecialFunc(handleSpecialKeys); // Register special keys handler
    initGL();
    gluOrtho2D(-50.0, 50.0, 40.0, -40.0); // Adjusted Y range to match display
    glutMainLoop();
    return 0;
}
