using System;
using System.Collections.Generic;

class MainClass {

  public static void Main (string[] args) {

  Artist a1 = new Artist ("Taylor", "Swift");

  a1.Display();


  Song x = new Song (1234567891, "Girl at Home");
  Song y = new Song (1234567819, "The Last Time");
  Song z = new Song (1234567812, "Teardrops");

  x.AddArtistInfo(a1);
  y.AddArtistInfo(a1);
  z.AddArtistInfo(a1);

  x.DisplaySong();
  y.DisplaySong();
  z.DisplaySong();

  Album r = new Album ("Red");

  r.AddSongs(x);
  r.AddSongs(y);
  r.AddSongs(z);

  r.DisplaySongs();

  r.RemoveSong(x);
  
   r.DisplaySongs();



  }
}