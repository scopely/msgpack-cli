﻿#region -- License Terms --
//
// MessagePack for CLI
//
// Copyright (C) 2010 FUJIWARA, Yusuke
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
#endregion -- License Terms --

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.IO;
using NUnit.Framework;

namespace MsgPack.Serialization
{
	[DataContract]
	public class ComplexTypeWithDataContract : IVerifiable
	{
		// FIXME: [DataMember] named properties

		[DataMember]
		public Uri Source { get; set; }
		[DataMember]
		public DateTime TimeStamp { get; set; }
		[DataMember]
		public byte[] Data { get; set; }

		private readonly Dictionary<DateTime, string> _history = new Dictionary<DateTime, string>();

		[DataMember]
		public Dictionary<DateTime, string> History
		{
			get { return this._history; }
		}

		public object NonSerialized { get; set; }

		// FIXME: MsgPackMemberAttribute test
		// FIXME: with Number test
		public void Verify( Stream stream )
		{
			stream.Position = 0;
			var data = Unpacking.UnpackObject( stream );
			NUnit.Framework.Assert.That( data, Is.Not.Null );
			if ( data.IsDictionary )
			{
				var map = data.AsDictionary();
				NUnit.Framework.Assert.That( map.ContainsKey( "Source" ) );
				NUnit.Framework.Assert.That( map[ "Source" ].AsString(), Is.EqualTo( this.Source.ToString() ) );
				NUnit.Framework.Assert.That( map.ContainsKey( "TimeStamp" ) );
				NUnit.Framework.Assert.That( MessagePackConvert.ToDateTime( map[ "TimeStamp" ].AsInt64() ), Is.EqualTo( this.TimeStamp ) );
				NUnit.Framework.Assert.That( map.ContainsKey( "Data" ) );
				NUnit.Framework.Assert.That( map[ "Data" ].AsBinary(), Is.EqualTo( this.Data ) );
				NUnit.Framework.Assert.That( map.ContainsKey( "History" ) );
				NUnit.Framework.Assert.That( map[ "History" ].AsDictionary().Count, Is.EqualTo( this.History.Count ) );
			}
			else
			{
				// FIXME: Alphabetical order
				var array = data.AsList();
				NUnit.Framework.Assert.That( array[ 0 ].AsString(), Is.EqualTo( this.Source.ToString() ) );
				NUnit.Framework.Assert.That( MessagePackConvert.ToDateTime( array[ 1 ].AsInt64() ), Is.EqualTo( this.TimeStamp ) );
				NUnit.Framework.Assert.That( array[ 2 ].AsBinary(), Is.EqualTo( this.Data ) );
				NUnit.Framework.Assert.That( array[ 3 ].AsDictionary().Count, Is.EqualTo( this.History.Count ) );
			}
		}
	}
}
