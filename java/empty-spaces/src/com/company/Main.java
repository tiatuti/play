package com.company;

public class Main {

    public static void main(String[] args) {
	// write your code here

        preference myPref = preference.wantView;
        myPref.change(true);

        System.out.println(myPref.toString());
        System.out.println(myPref.getPref());
        System.out.println("=============================");


        person p = new person( "Capricorn Galaxy", "female", 1, 4, "Miami");

        p.updatePreferences( myPref, true);

    }


}
