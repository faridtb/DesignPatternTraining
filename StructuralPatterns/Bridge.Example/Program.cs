using Bridge.Example.Concretes;
using Bridge.Example.Interfaces;

Music music = new("Üzeyir Hacıbəyov - Cəngi", "50");

Spotify spotify = new();
Fizy fizy = new();

Speaker speaker = new();
HeadPhones headPhones = new();


Device comp = new Computer(headPhones,fizy);

comp.PlayMusic(music);