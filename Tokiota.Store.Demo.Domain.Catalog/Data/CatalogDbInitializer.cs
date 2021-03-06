﻿namespace Tokiota.Store.Demo.Domain.Catalog.Data
{
    using Model;
    using System;
    using System.Data.Entity;
    using Services;
    using Infrastructure;

    internal class CatalogDbInitializer : DropCreateDatabaseIfModelChanges<CatalogDbContext> //DropCreateDatabaseAlways<CatalogDbContext>
    {
        protected override void Seed(CatalogDbContext context)
        {
            CreateProduct(context, "Gravity", "Bullock interpreta a la doctora Ryan Stone, una brillante ingeniera especializada en medicina en su primera misión en un transbordador, con el veterano astronauta Matt Kowalsky (Clooney). Pero en un paseo espacial aparentemente de rutina se desencadena el desastre. El transbordador queda destruido, dejando a Stone y Kowalsky completamente solos, unidos el uno al otro y dando vueltas en la oscuridad.", Category.ScyFy, 27.42m, "/images/gravity.jpg");
            CreateProduct(context, "World War Z", "Cuando el mundo comienza a ser invadido por una pandemia de muertos vivientes, el experto investigador de las Naciones Unidas Gerry Lane (Brad Pitt) intentará evitar lo que podría ser el fin de la civilización en una carrera contra el tiempo y el destino. La destrucción a la que se ve sometida la raza humana le hace recorrer el mundo entero buscando respuestas sobre cómo parar la horrible epidemia que amenaza a toda la humanidad, intentando salvar las vidas de millones de desconocidos así como la de su propia familia.", Category.Terror, 28.18m, "/images/WorldWarZ.jpg");
            CreateProduct(context, "Avatar", "En la aventura épica AVATAR, James Cameron, el director de 'Titanic', nos lleva a un espectacular nuevo mundo más allá de nuestra imaginación. En una lejana luna llamada Pandora, un héroe inesperado se embarca en un viaje de autosalvación y descubrimiento mientras lidera una heroica batalla para salvar una civilización. La película fue ideada por Cameron hace 14 años, cuando los medios técnicos, no permitían hacer realidad su visión. Ahora, después de 4 años de producción, AVATAR nos sumerge en una experiencia cinematográfica completamente nueva, donde la revolucionaria tecnología inventada para la película, pasa desapercibida ante la contundencia de los personajes y la conmovedora historia.", Category.Adventure, 18.15m, "/images/avatar.jpg");
            CreateProduct(context, "Intouchables", "Tras un accidente de parapente, Philippe, un rico aristócrata, contrata a Driss como asistente y cuidador, un joven procedente de un barrio de viviendas públicas que ha salido recientemente de prisión —en otras palabras, la persona menos indicada para el trabajo—. Juntos van a mezclar a Vivaldi y “Earth, Wind & Fire”, la dicción elegante y la jerga callejera, los trajes y los pantalones de chándal. Dos mundos van a chocar y van a tener que entenderse mutuamente para dar lugar a una amistad tan demencial, cómica y sólida como inesperada, una relación singular que genera energía y los hace… ¡intocables!", Category.Comedy, 15.41m, "/images/Intouchables.jpg");
            CreateProduct(context, "El Hobbit", "\"El Hobbit: La Desolación de Smaug\" continua la aventura de Bilbo Bolsón en su viaje con el mago Gandalf y trece enanos liderados por Thorin Escudo de Roble en una búsqueda épica para reclamar el reino enano de Erebor. En su camino toparán con multitud de peligros y harán frente al temible dragón Smaug.", Category.Adventure, 26.18m, "/images/hobbit.jpg");
            CreateProduct(context, "Frozen", "Anna, una optimista y valiente chica, se embarca en un viaje épico en el que hará equipo con Kristoff, un audaz hombre de montaña, y su fiel reno Sven, para encontrar a su hermana Elsa, cuyos poderes de hielo han atrapado al reino de Arendelle en un invierno eterno. Se encontrarán con situaciones extremas, duendes místicos y un muñeco de nieve muy divertido llamado Olaf. Juntos lucharán contra los elementos para salvar el reino.", Category.Comedy, 26.83m, "/images/frozen.jpg");
            CreateProduct(context, "Malditos Bastardos", "Segunda Guerra Mundial. Durante la ocupación alemana de Francia, Shosanna Dreyfus (Mélanie Laurent) presencia la ejecución de su familia a manos del coronel nazi Hans Landa (Christoph Waltz). Shosanna consigue escapar y huye a París, donde se forja una nueva identidad como dueña y directora de un cine. En otro lugar de Europa, el teniente Aldo Raine (Brad Pitt) organiza un grupo de soldados judíos para tomar represalias contra objetivos concretos. Conocidos por el enemigo como “The Basterds” (Los cabrones), los hombres de Raine se unen a la actriz alemana Bridget Von Hammersmark (Diane Kruger), una agente secreto que trabaja para los aliados, con el fin de llevar a cabo una misión que hará caer a los líderes del Tercer Reich. El destino quiere que todos se encuentren bajo la marquesina de un cine donde Shosanna espera para vengarse...", Category.Adventure, 7.54m, "/images/malditosbastardos.jpg");
            CreateProduct(context, "Jurasic Park", "Con unos efectos visuales merecedores del Academy Award y un rodaje innovador que ha sido aclamado como un rotundo triunfo del arte de los efectos especiales, esta cinta épica supone pura magia cinematográfica sobre algo que tardó en crearse 65 millones de años. Parque Jurásico te lleva a un increíble parque temático en una isla remota donde los dinosaurios que una vez deambularon por la tierra y cinco personas, se enfrentan a una lucha por la supervivencia. Protagonizada por Sam Neill, Laura Dern, Jeff Goldblum y Richard Attenborough, descubre la sobrecogedora aventura que desearás vivir una y otra vez.", Category.Adventure, 19.06m, "/images/jurasicpark.jpg");
            CreateProduct(context, "Gladiator", "En el año 180, el Imperio Romano domina todo el mundo conocido. Tras una gran victoria sobre los bárbaros del norte, el anciano emperador Marco Aurelio (Richard Harris) decide transferir el poder a Máximo (Russell Crowe), bravo general de sus ejércitos y hombre de inquebrantable lealtad al imperio. Pero su hijo Cómodo (Joaquin Phoenix), que aspiraba al trono, no lo acepta y trata de asesinar a Máximo.", Category.Adventure, 19.06m, "/images/gladiator.jpg");
            CreateProduct(context, "Tintín", "El Capitán Haddock recibe un viejo barco como herencia tras la muerte de un amigo. Al llegar a Turquía, donde se encuentra el barco, varios compradores insisten en comprarlo, hecho que extraña enormemente al Capitán, ya que el navío es una auténtica ruina. Pero lo que desconoce el Capitán es el secreto que esconde ese barco.", Category.Adventure, 10.41m, "/images/tintin.jpg");
            CreateProduct(context, "Matrix Trilogy", "Existen dos realidades: una que consiste en la vida que vivimos cada día, y otra que se encuentra detrás de ella. Una es un sueño. La otra The Matrix (La Matriz). ¿Has tenido alguna vez un sueño del que estuvieras muy seguro de que era real?. Neo, esta buscando desesperadamente la verdad sobre The Matrix, algo de lo que ha oído hablar sólo en susurros, algo misterioso y desconocido. Neo está seguro de que algo tiene un control inimaginable y siniestro sobre su vida.¿Qué es The Matrix? Neo cree que Morpheus, una persona a la que sólo conoce a través de la leyenda, una esquiva figura considerada como el hombre vivo más peligroso, puede darle la respuesta.", Category.ScyFy, 11.20m, "/images/matrix.jpg");
            CreateProduct(context, "Merlin el Encantador", "Disney se enorgullece de presentar la edición 50 aniversario de este hechizante clásico. Merlín el Encantador, nominada al Oscar por su banda sonora, viene cargada de magia, diversión y aventura, ¡ahora por primera vez en Blu-ray!Embárcate en una aventura fantástica junto al huérfano Grillo y el extraordinario mago Merlín. Según la leyenda, solo alguien con honor, pureza de corazón y fortaleza interior podrá sacar una antigua espada encantada clavada en una piedra y reclamar el trono de Inglaterra. Armado con confianza y el poder de la amistad, Grillo descubre su destino y aprende que la mejor magia es la que está en el interior de cada uno.", Category.Adventure, 13.97m, "/images/merlin.jpg");
            CreateProduct(context, "Buscando a Nemo", "Esta asombrosa aventura submarina poblada de personajes memorables, humor y sentimientos narra el divertido y trascendental viaje de un sobreprotector pez payaso llamado Marlin y su hijo Nemo, que se separan en la Gran Barrera de Coral cuando, de repente, Nemo sale inesperadamente de su hogar marino para acabar en la pecera de un dentista. Animado por la compañía de Dory, una simpática y despistada pez cirujano azul, Marlin se embarca en una ruta peligrosa y acaba convirtiéndose en el héroe improvisado de la épica aventura del rescate de su hijo, quien también tramará algún que otro intrépido plan para regresar a casa sano y salvo.", Category.Comedy, 11.72m, "/images/nemo.jpg");
            base.Seed(context);
        }

        private static void CreateProduct(CatalogDbContext context, string name, string description, Category category, decimal price, string image)
        {
            var service = ApplicationConfig.Resolve<IImageStorageService>();
            var file = System.Web.HttpContext.Current.Server.MapPath(image);
            string imageUrl;
            using (var reader = System.IO.File.OpenRead(file))
            {
                imageUrl = service.SaveImage(file, reader);
            }

            var p = new Product
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Description = description,
                Category = category,
                Price = price,
                Image = imageUrl
            };
            context.Products.Add(p);
        }
    }
}
