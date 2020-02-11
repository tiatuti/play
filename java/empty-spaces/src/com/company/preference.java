package com.company;

public enum preference{
    usesRoom("usesRoom", true),
    doesHWinRoom("doesHWinRoom", false),
    eatInRoom("eatInRoom", true),
    wantViewEating("wantViewEating", true),
    praysInRoom("praysInRoom", false),
    drinksCoffeeInRoom("drinksCoffeeInRoom", false),
    wantView("wantView", true),
    wantNaturalLight("wantNaturalLight", true),
    chargePhoneInRoom("chargePhoneInRoom", true),
    haveGuestsFrequently("haveGuestsFrequently", false),
    splitRoomFromKitchen("splitRoomFromKitchen", false),
    bringSportsEquipment("bringSportsEquipment", false);


    private String name;
    private boolean flag;

     preference(String name, boolean flag){
        this.name = name;
        this.flag = flag;
    }

    public void change(boolean flag) {

         this.flag = flag;
    }

    public boolean getPref() {

         return this.flag;
    }
}

