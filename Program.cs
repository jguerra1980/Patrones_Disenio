// See https://aka.ms/new-console-template for more information

//var singleton = new Singleton.Singleton(); // esto no permite por que el constructor está privado

//var log = new Singleton.log(); // esto no permite por que el constructor está privado

var log = Singleton.Singleton.Log.Instance;
log.guardarlog("J");
log.guardarlog("o");
log.guardarlog("s");
log.guardarlog("G");

