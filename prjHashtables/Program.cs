using System.Collections;
using prjHashtables;

Hashtable influencers = new Hashtable(10);
influencers.Add("john_doe", new Influencer("john_doe", 1500, 0.05, "Check out my latest post!"));
influencers.Add("jane_smith", new Influencer("jane_smith", 2500, 0.07, "Loving this new product!"));
influencers.Add("alice_jones", new Influencer("alice_jones", 3000, 0.10, "Just launched my new blog!"));

Influencer influencer = influencers.Get("john_doe");

if (influencer != null)
{
    Console.WriteLine(influencer);
}
else
{
    Console.WriteLine("Influencer not found.");
}
