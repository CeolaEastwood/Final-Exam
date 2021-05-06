using System;
using System.Collections.Generic;

class Album{

  public string AlbumTitle;

  public List<Song> SongList = new List<Song>();

  public Album (string albumtitle){
  AlbumTitle = albumtitle;
  }


  public void AddSongs(Song s){
    SongList.Add(s);
    Console.WriteLine("Song: "  + s.Title + " added to list.");

  }
  
  public void RemoveSong(Song a){
    Song f = SongList.Find(o=>o.Id == a.Id);
    SongList.Remove(f);
    Console.WriteLine("Song: "  + f.Title + " removed from list.");

  }

  public void DisplaySongs(){

    Console.WriteLine("Songs in the Album: " + AlbumTitle);
    foreach (Song s in SongList)
    { 
      s.DisplaySong();
    }
  }
}

 