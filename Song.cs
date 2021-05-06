using System;
using System.Collections.Generic;

class Song{

public int Id;
public string Title  {get; set;}
public string ArtistInfo  {get; set;}

/*
public int Id { 
  get{
      return Id;
    }
  set {
      if (value.Length != 10)
          Console.WriteLine("Invalid ID");
        else
          Id = value;
        }
}*/

public Song (){
  Title = "unknown";
  Id = 0;
  ArtistInfo = "unknown";
}

public Song (int id, string title){

  Title = title;
  Id = id;
  
}

public void AddArtistInfo (Artist a){

  Console.WriteLine ("Artist: " + a.FirstName + " "+ a.LastName + " added the song called " + Title);
}

public void DisplaySong(){
  Console.WriteLine("Song: "+ Id + " " + Title +" " + ArtistInfo);
}

}