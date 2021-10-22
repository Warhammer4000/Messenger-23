using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AlphabetData
{
    public readonly static Dictionary<int, string> englishAlphabetDictionary = new Dictionary<int, string>
    {
        //smallercase
        {0, "\u0031"},  {1, "\u0032"},  {2,"\u0033"},   {3, "\u0034"},  {4, "\u0035"},  {5, "\u0036"},  {6, "\u0037"},  {7, "\u0038"},  {8, "\u0039"},  {9, "\u0030"},
        {10, "\u0071"}, {11, "\u0077"}, {12, "\u0065"}, {13, "\u0072"}, {14, "\u0074"}, {15, "\u0079"}, {16, "\u0075"}, {17, "\u0069"}, {18, "\u006F"}, {19, "\u0070"},
        {20, "\u0061"}, {21, "\u0073"}, {22, "\u0064"}, {23, "\u0066"}, {24, "\u0067"}, {25, "\u0068"}, {26, "\u006A"}, {27, "\u006B"}, {28, "\u006C"},
        {29, "\u007A"}, {30, "\u0078"}, {31, "\u0063"}, {32, "\u0076"}, {33, "\u0062"}, {34, "\u006E"}, {35, "\u006D"},
        //Uppercase
        {46, "\u0051"},  {47, "\u0057"},  {48,"\u0045"},   {49, "\u0052"},  {50, "\u0054"},  {51, "\u0059"},  {52, "\u0055"},  {53, "\u0049"},  {54, "\u004F"},  {55, "\u0050"},
        {56, "\u0041"},  {57, "\u0053"},  {58,"\u0044"},   {59, "\u0046"},  {60, "\u0047"},  {61, "\u0048"},  {62, "\u004A"},  {63, "\u004B"},  {64, "\u004C"},
        {65, "\u005A"}, {66, "\u0058"},  {67, "\u0043"},  {68,"\u0056"},   {69, "\u0042"},  {70, "\u004E"},  {71, "\u004D"},

       //Symble 1
        {108, "\u0060"}, {109, "\u007E"}, {110, "\u005C"}, {111, "\u007C"}, {112, "\u003C"}, {113, "\u003E"}, {114, "\u007B"}, {115, "\u007D"}, {116, "\u005B"}, {117, "\u005D"},
        {118, "\u00C6"}, {119, "\u00A7"}, {120, "\u00B4"}, {121, "\u00AE"}, {122, "\u2020"}, {123, "\u00B6"}, {124, "\u00B5"}, {125, "\u00BB"}, {126, "\u00C7"},
        {127, "\u002E"}, {128, "\u00DF"}, {129, "\u00F8"}, {130, "\u00A9"}, {131, "\u00F2"}, {132, "\u00EB"}, {133, "\u00BA"},


        //Symble2
         {82, "\u002B"},  {83, "\u0078"},  {84,"\u00F7"},   {85, "\u003D"},  {86, "\u002F"},  {87, "\u005F"},  {88, "\u20AC"},  {89, "\u00A3"},  {90, "\u00A5"},  {91, "\u0028"},
        {92, "\u0021"},  {93, "\u0040"},  {94,"\u0023"},   {95, "\u0024"},  {96, "\u0025"},  {97, "\u005E"},  {98, "\u0026"},  {99, "\u002A"},  {100, "\u0029"},
        {101, "\u002D"},  {102, "\u0027"},  {103,"\u0022"},   {104, "\u003A"},  {105, "\u003B"},  {106, "\u002C"},  {107, "\u003F"}

    };


    public readonly static Dictionary<int, string> banglaAlphabetDictionary = new Dictionary<int, string>
    {
        {0, "\u0985"},  {1, "\u0986"},  {2,"\u0987"},   {3, "\u0988"},  {4, "\u0989"},  {5, "\u098A"}
        /*{"\u098B", "R"},    {"\u098F", "E"},    {"\u0990", "AI"},   {"\u0993", "O"},    {"\u0994", "AU"},   {"\u0995", "KA"},
        {"\u0996", "KHA"},  {"\u0997", "GA"},   {"\u0998", "GHA"},  {"\u0999", "NGA"},  {"\u099A", "CA"},   {"\u099B", "CHA"},
        {"\u099C", "JA"},   {"\u099D", "JHA"},  {"\u099E", "NYA"},  {"\u099F", "TTA"},  {"\u09A0", "TTHA"}, {"\u09A1", "DDA"},
        {"\u09A2", "DDHA"}, {"\u09A3", "NNA"},  {"\u09A4", "TA"},   {"\u09A5", "THA"},  {"\u09A6", "DA"},   {"\u09A7", "DHA"},
        {"\u09A8", "NA"},   {"\u09AA", "PA"},   {"\u09AB", "PHA"},  {"\u09AC", "BA"},   {"\u09AD", "BHA"},  {"\u09AE", "MA"},
        {"\u09AF", "YA"},   {"\u09B0", "RA"},   {"\u09B2", "LA"},   {"\u09B6", "SHA"},  {"\u09B7", "SSA"},  {"\u09B8", "SA"},
        {"\u09B9", "HA"},   {"\u09DC", "RRA"},  {"\u09DD", "RHA"},  {"\u09DF", "YYA"}*/
    };
}
