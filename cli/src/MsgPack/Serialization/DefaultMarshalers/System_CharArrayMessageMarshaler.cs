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

namespace MsgPack.Serialization.DefaultMarshalers
{
	internal sealed class System_CharArrayMessageMarshaler : MessageMarshaler<char[]>
	{
		protected sealed override void MarshalToCore( Packer packer, char[] value )
		{
			if ( value == null )
			{
				packer.PackNull();
			}
			else
			{
				packer.PackString( value );
			}
		}

		protected sealed override char[] UnmarshalFromCore( Unpacker unpacker )
		{
			var result = unpacker.Data.Value;
			return result.IsNil ? null : result.AsCharArray();
		}
	}
}