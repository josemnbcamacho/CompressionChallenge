﻿using Core.Data;
using K4os.Compression.LZ4.Streams;
using MessagePack;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System.Collections.Generic;
using System.IO;

namespace Core.Tests
{
    public class MsgPackTest : BaseTest
    {
        public override string TestName => "MsgPack (uncompressed)";

        public override bool IsBaseline => false;

        public override string Filename => "test.msgpack";

        public override byte[] Execute(List<Contact> list)
        {
            return MessagePackSerializer.Serialize(list);
        }
    }
}
