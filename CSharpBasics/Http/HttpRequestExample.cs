using System;
using System.Net;
using System.Web;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace CSharpBasics
{
	/* Topic: Calling REST API using HttpWebRequest
	 * 
	 * Key Classes: WebRequest, HttpWebRequest, HttpWebResponse, StreamReader, StreamWriter
	 * 
	 * Key Methods:
	 * 		- WebRequest.Create()
	 * 		- HttpWebRequest.ContentType
	 * 		- HttpWebRequest.Method
	 * 		- HttpWebRequest.GetResponse()
	 * 		- HttpWebRequest.GetRequestStream()
	 * 		- HttpWebResponse.GetResponseStream()
	 * 		- StreamReader.ReadToEnd()
	 * 		- StreamWriter.Write()
	 * 		- StreamWriter.Flush()
	 * 
	 */

	public class HttpRequestExample
	{
		string baseUri = "http://jsonplaceholder.typicode.com";

		public void Execute(){

			//Console.WriteLine ("GET: Get all posts");
			//GetPosts ();

			Console.WriteLine ("POST: Add a Post");
			int id = Post ();

			if (id > 0) {
				
				id = 1;
				Console.WriteLine ("GET: Post with id {0}", id);
				GetPost (1);

				Console.WriteLine ("PATCH: Post with id {0}", id);
				Patch (1);

				Console.WriteLine ("PUT: Post with id {0}", id);
				Put (1);

				Console.WriteLine ("DELETE: Post with id {0}", id);
				Delete (1);
			}
		}

		public void GetPosts() {			
			var uri = string.Format("{0}/posts", baseUri);
			var request = (HttpWebRequest)WebRequest.Create(uri);
			request.ContentType = "application/json";
			request.Method = "GET";
			var response = (HttpWebResponse)request.GetResponse();
			var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
			Console.WriteLine (responseString);
		}

		public void GetPost(int id) {			
			var uri = string.Format("{0}/posts/{1}", baseUri, id);
			var request = (HttpWebRequest)WebRequest.Create(uri);
			request.ContentType = "application/json";
			request.Method = "GET";
			var response = (HttpWebResponse)request.GetResponse();
			var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
			Console.WriteLine (responseString);
		}

		public int Post() {			
			int id = 0;
			var uri = string.Format("{0}/posts", baseUri);
			string json = "{\"title\":\"ABC\",\"body\":\"XYZ\",\"userId\":1}";
			HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(uri);
			myHttpWebRequest.Method = "POST";
			myHttpWebRequest.ContentType = "application/json; charset=utf-8";


			using (var streamWriter = new StreamWriter(myHttpWebRequest.GetRequestStream()))
			{
				streamWriter.Write(json);
				streamWriter.Flush();
			}

			var httpResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
			using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
			{
				var responseText = streamReader.ReadToEnd();
				var idString = responseText.Replace("{",string.Empty).Replace("}",string.Empty).Replace("\n",string.Empty).Split(':');
				int.TryParse (idString[4], out id);
				Console.WriteLine (responseText);
			}
			return id;
		}

		public void Put(int id) {			
			var uri = string.Format("{0}/posts/{1}", baseUri, id);
			string json = "{\"id\":\""+  id + "\",\"title\":\"John\",\"body\":\"Cena\",\"userId\":1}";
			HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(uri);
			myHttpWebRequest.Method = "PUT";
			myHttpWebRequest.ContentType = "application/json; charset=utf-8";


			using (var streamWriter = new StreamWriter(myHttpWebRequest.GetRequestStream()))
			{
				streamWriter.Write(json);
				streamWriter.Flush();
			}

			var httpResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
			using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
			{
				var responseText = streamReader.ReadToEnd();
				Console.WriteLine (responseText);
			}
		}

		public void Delete(int id) {			
			var uri = string.Format("{0}/posts/{1}", baseUri, id);
			var request = (HttpWebRequest)WebRequest.Create(uri);
			request.ContentType = "application/json; charset=utf-8";
			request.Method = "DELETE";
			var response = (HttpWebResponse)request.GetResponse();
			var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
			Console.WriteLine (responseString);
		}

		public void Patch(int id) {			
			var uri = string.Format("{0}/posts/{1}", baseUri, id);
			string json = "{\"title\":\"Sam\"}";
			HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(uri);
			myHttpWebRequest.Method = "PATCH";
			myHttpWebRequest.ContentType = "application/json; charset=utf-8";


			using (var streamWriter = new StreamWriter(myHttpWebRequest.GetRequestStream()))
			{
				streamWriter.Write(json);
				streamWriter.Flush();
			}

			var httpResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
			using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
			{
				var responseText = streamReader.ReadToEnd();
				Console.WriteLine (responseText);
			}
		}
	}
}

