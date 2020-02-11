package com.company;

enum orientation {

    NORTH, SOUTH, EAST, WEST
}

public class furniture {

    private int width;
    private int height;
    private int x;
    private int y;
    private orientation direction;

    // constructor
    public furniture( int currentWidth, int currentHeight, int xPos, int yPos, orientation currentDirection ){

        width = currentWidth;
        height = currentHeight;
        x = xPos;
        y = yPos;
        direction = currentDirection;

    }

    public int changeDirection( orientation newDirection ) {

        try {
            //  Block of code to try

            direction = newDirection;
        }
        catch(Exception e) {


            // re-throw exception - consider creating your own exception class
            //throw new agentException("your custom messages");
        }

        return 0;
    }

    public int changeLocation( int xPos, int yPos) {

        try {
            //  Block of code to try

            x = xPos;
            y = yPos;
        }
        catch(Exception e) {

            // re-throw exception - consider creating your own exception class
            //throw new agentException("your custom messages");
        }

        return 0;

    }

}
