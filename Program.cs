using DesafioPOO.Models;

Nokia celNokia = new Nokia("11 95454-5454", "Moto G", "78789879879", 256);
celNokia.Ligar();
celNokia.ReceberLigacao();
celNokia.InstalarAplicativo("WhatsApp");

Iphone celIphone = new Iphone("11 95454-5454", "Iphone 16", "78789879879", 256);
celIphone.Ligar();
celIphone.ReceberLigacao();
celIphone.InstalarAplicativo("WhatsApp");
