package com.company;

import java.util.ArrayList;
import java.util.List;

public class person {

    public List<preference> myPrefs = new ArrayList<preference>();
    private String myBldg;
    private String myGender;
    private int myAcademicYr;
    private int myNumOfRoommates;
    private String myHometown;


    // I would move these below to preferences enum, because the person controls these liking
    // versus things we don't control such as age, and building assigned
    /*

    Athlete, Pets, Disabilities, Drink

    */


    // default constructor
    public person( String bldg, String gender, int academicYr, int numOfRoommates, String homeTown ) {

        myBldg = bldg;
        myGender = gender;
        myAcademicYr = academicYr;
        myNumOfRoommates = numOfRoommates;
        myHometown = homeTown;

    }

    public void survey() {

    }

    public void updatePreferences(preference myPreference, boolean flag) {

        // needs meat to search for particular preference and update boolean with new 'flag' value
        for (preference pref : preference.values()) {
            System.out.println(pref + "   " + pref.getPref());
        }


    }


}
