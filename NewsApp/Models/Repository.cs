using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsApp.Models
{
  public static class Repository
  {
    public static List<Article> articles = new List<Article>() {
            new Article() {
                Id = 1,
                Headline = "Heiterkeit",
                Content = @"Eine wunderbare Heiterkeit hat meine ganze Seele eingenommen, 
gleich den süßen Frühlingsmorgen, die ich mit ganzem Herzen genieße. Ich bin allein und 
freue mich meines Lebens in dieser Gegend, die für solche Seelen geschaffen ist wie die 
meine. Ich bin so glücklich, mein Bester, so ganz in dem Gefühle von ruhigem Dasein versunken, 
daß meine Kunst darunter leidet. Ich könnte jetzt nicht zeichnen, nicht einen Strich, und bin
nie ein größerer Maler gewesen als in diesen Augenblicken.",
                Created = new DateTime(2022, 2, 25),
                Author = "Werther",
                ImageFile = "image01.jpg"

            },
            new Article() {
                Id = 2,
                Headline = "Lorem Ipsum",
                Content = @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. 
Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis 
parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, 
pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet 
nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. 
Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum 
semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, 
eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus 
viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi 
vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus",
                Created = new DateTime(2022, 2, 26),
                Author = "Lorem Lorem",
                ImageFile = "image02.jpg"
            },
            new Article() {
                Id = 3,
                Headline = "Josef K.",
                Content = @"Jemand musste Josef K. verleumdet haben, denn ohne dass er etwas 
Böses getan hätte, wurde er eines Morgens verhaftet. »Wie ein Hund!« sagte er, es war, als 
sollte die Scham ihn überleben. Als Gregor Samsa eines Morgens aus unruhigen Träumen erwachte, 
fand er sich in seinem Bett zu einem ungeheueren Ungeziefer verwandelt. Und es war ihnen wie 
eine Bestätigung ihrer neuen Träume und guten Absichten, als am Ziele ihrer Fahrt die Tochter 
als erste sich erhob und ihren jungen Körper dehnte. »Es ist ein eigentümlicher Apparat«, sagte 
der Offizier zu dem Forschungsreisenden und überblickte mit einem gewissermaßen bewundernden Blick 
den ihm doch wohlbekannten Apparat.",
                Created = new DateTime(2022, 2, 27),
                Author = "Kafka",
                ImageFile = "image03.jpg"

            },
            new Article() {
                Id = 4,
                Headline = "Pressekonferenz",
                Content = @"Es gibt im Moment in diese Mannschaft, oh, einige Spieler vergessen 
ihnen Profi was sie sind. Ich lese nicht sehr viele Zeitungen, aber ich habe gehört viele Situationen. 
Erstens: wir haben nicht offensiv gespielt. Es gibt keine deutsche Mannschaft spielt offensiv und die 
Name offensiv wie Bayern. Letzte Spiel hatten wir in Platz drei Spitzen: Elber, Jancka und dann Zickler. 
Wir müssen nicht vergessen Zickler. Zickler ist eine Spitzen mehr, Mehmet eh mehr Basler. Ist klar diese 
Wörter, ist möglich verstehen, was ich hab gesagt? Danke.",
                Created = new DateTime(2022, 2, 28),
                Author = "Trappatoni",
                ImageFile = "image04.jpg"

            }
        };
    public static List<Article> GetAllArticles()
    {
      return articles;
    }
    public static void AddArticle(Article article)
    {
      articles.Add(article);
    }
    public static Article GetArticleById(int id)
    {
      return articles.FirstOrDefault(a => a.Id == id);
    }
    public static void RemoveArticle(int id)
    {

      articles.Remove(articles.FirstOrDefault(a => a.Id == id));
    }
  }
}
