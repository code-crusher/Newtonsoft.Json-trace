#region License
// Copyright (c) 2007 James Newton-King
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

#if DNXCORE50
using Xunit;
using Test = Xunit.FactAttribute;
using Assert = Newtonsoft.Json.Tests.XUnitAssert;
#else
using NUnit.Framework;
#endif

namespace Newtonsoft.Json.Tests.Issues
{
    [TestFixture]
    public class Issue3103
    {
        [Test]
        public void Test()
        {
            Dummy dummy = new Dummy(0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254);

            string json = JsonConvert.SerializeObject(dummy);
            Dummy deserialized = JsonConvert.DeserializeObject<Dummy>(json);

            Assert.AreEqual(dummy.P0, deserialized.P0);
            Assert.AreEqual(dummy.P254, deserialized.P254);
        }

        public class Dummy
        {
            public Dummy(                int p0,
                int p1,
                int p2,
                int p3,
                int p4,
                int p5,
                int p6,
                int p7,
                int p8,
                int p9,
                int p10,
                int p11,
                int p12,
                int p13,
                int p14,
                int p15,
                int p16,
                int p17,
                int p18,
                int p19,
                int p20,
                int p21,
                int p22,
                int p23,
                int p24,
                int p25,
                int p26,
                int p27,
                int p28,
                int p29,
                int p30,
                int p31,
                int p32,
                int p33,
                int p34,
                int p35,
                int p36,
                int p37,
                int p38,
                int p39,
                int p40,
                int p41,
                int p42,
                int p43,
                int p44,
                int p45,
                int p46,
                int p47,
                int p48,
                int p49,
                int p50,
                int p51,
                int p52,
                int p53,
                int p54,
                int p55,
                int p56,
                int p57,
                int p58,
                int p59,
                int p60,
                int p61,
                int p62,
                int p63,
                int p64,
                int p65,
                int p66,
                int p67,
                int p68,
                int p69,
                int p70,
                int p71,
                int p72,
                int p73,
                int p74,
                int p75,
                int p76,
                int p77,
                int p78,
                int p79,
                int p80,
                int p81,
                int p82,
                int p83,
                int p84,
                int p85,
                int p86,
                int p87,
                int p88,
                int p89,
                int p90,
                int p91,
                int p92,
                int p93,
                int p94,
                int p95,
                int p96,
                int p97,
                int p98,
                int p99,
                int p100,
                int p101,
                int p102,
                int p103,
                int p104,
                int p105,
                int p106,
                int p107,
                int p108,
                int p109,
                int p110,
                int p111,
                int p112,
                int p113,
                int p114,
                int p115,
                int p116,
                int p117,
                int p118,
                int p119,
                int p120,
                int p121,
                int p122,
                int p123,
                int p124,
                int p125,
                int p126,
                int p127,
                int p128,
                int p129,
                int p130,
                int p131,
                int p132,
                int p133,
                int p134,
                int p135,
                int p136,
                int p137,
                int p138,
                int p139,
                int p140,
                int p141,
                int p142,
                int p143,
                int p144,
                int p145,
                int p146,
                int p147,
                int p148,
                int p149,
                int p150,
                int p151,
                int p152,
                int p153,
                int p154,
                int p155,
                int p156,
                int p157,
                int p158,
                int p159,
                int p160,
                int p161,
                int p162,
                int p163,
                int p164,
                int p165,
                int p166,
                int p167,
                int p168,
                int p169,
                int p170,
                int p171,
                int p172,
                int p173,
                int p174,
                int p175,
                int p176,
                int p177,
                int p178,
                int p179,
                int p180,
                int p181,
                int p182,
                int p183,
                int p184,
                int p185,
                int p186,
                int p187,
                int p188,
                int p189,
                int p190,
                int p191,
                int p192,
                int p193,
                int p194,
                int p195,
                int p196,
                int p197,
                int p198,
                int p199,
                int p200,
                int p201,
                int p202,
                int p203,
                int p204,
                int p205,
                int p206,
                int p207,
                int p208,
                int p209,
                int p210,
                int p211,
                int p212,
                int p213,
                int p214,
                int p215,
                int p216,
                int p217,
                int p218,
                int p219,
                int p220,
                int p221,
                int p222,
                int p223,
                int p224,
                int p225,
                int p226,
                int p227,
                int p228,
                int p229,
                int p230,
                int p231,
                int p232,
                int p233,
                int p234,
                int p235,
                int p236,
                int p237,
                int p238,
                int p239,
                int p240,
                int p241,
                int p242,
                int p243,
                int p244,
                int p245,
                int p246,
                int p247,
                int p248,
                int p249,
                int p250,
                int p251,
                int p252,
                int p253,
                int p254)
            {
                P0 = p0;
                P1 = p1;
                P2 = p2;
                P3 = p3;
                P4 = p4;
                P5 = p5;
                P6 = p6;
                P7 = p7;
                P8 = p8;
                P9 = p9;
                P10 = p10;
                P11 = p11;
                P12 = p12;
                P13 = p13;
                P14 = p14;
                P15 = p15;
                P16 = p16;
                P17 = p17;
                P18 = p18;
                P19 = p19;
                P20 = p20;
                P21 = p21;
                P22 = p22;
                P23 = p23;
                P24 = p24;
                P25 = p25;
                P26 = p26;
                P27 = p27;
                P28 = p28;
                P29 = p29;
                P30 = p30;
                P31 = p31;
                P32 = p32;
                P33 = p33;
                P34 = p34;
                P35 = p35;
                P36 = p36;
                P37 = p37;
                P38 = p38;
                P39 = p39;
                P40 = p40;
                P41 = p41;
                P42 = p42;
                P43 = p43;
                P44 = p44;
                P45 = p45;
                P46 = p46;
                P47 = p47;
                P48 = p48;
                P49 = p49;
                P50 = p50;
                P51 = p51;
                P52 = p52;
                P53 = p53;
                P54 = p54;
                P55 = p55;
                P56 = p56;
                P57 = p57;
                P58 = p58;
                P59 = p59;
                P60 = p60;
                P61 = p61;
                P62 = p62;
                P63 = p63;
                P64 = p64;
                P65 = p65;
                P66 = p66;
                P67 = p67;
                P68 = p68;
                P69 = p69;
                P70 = p70;
                P71 = p71;
                P72 = p72;
                P73 = p73;
                P74 = p74;
                P75 = p75;
                P76 = p76;
                P77 = p77;
                P78 = p78;
                P79 = p79;
                P80 = p80;
                P81 = p81;
                P82 = p82;
                P83 = p83;
                P84 = p84;
                P85 = p85;
                P86 = p86;
                P87 = p87;
                P88 = p88;
                P89 = p89;
                P90 = p90;
                P91 = p91;
                P92 = p92;
                P93 = p93;
                P94 = p94;
                P95 = p95;
                P96 = p96;
                P97 = p97;
                P98 = p98;
                P99 = p99;
                P100 = p100;
                P101 = p101;
                P102 = p102;
                P103 = p103;
                P104 = p104;
                P105 = p105;
                P106 = p106;
                P107 = p107;
                P108 = p108;
                P109 = p109;
                P110 = p110;
                P111 = p111;
                P112 = p112;
                P113 = p113;
                P114 = p114;
                P115 = p115;
                P116 = p116;
                P117 = p117;
                P118 = p118;
                P119 = p119;
                P120 = p120;
                P121 = p121;
                P122 = p122;
                P123 = p123;
                P124 = p124;
                P125 = p125;
                P126 = p126;
                P127 = p127;
                P128 = p128;
                P129 = p129;
                P130 = p130;
                P131 = p131;
                P132 = p132;
                P133 = p133;
                P134 = p134;
                P135 = p135;
                P136 = p136;
                P137 = p137;
                P138 = p138;
                P139 = p139;
                P140 = p140;
                P141 = p141;
                P142 = p142;
                P143 = p143;
                P144 = p144;
                P145 = p145;
                P146 = p146;
                P147 = p147;
                P148 = p148;
                P149 = p149;
                P150 = p150;
                P151 = p151;
                P152 = p152;
                P153 = p153;
                P154 = p154;
                P155 = p155;
                P156 = p156;
                P157 = p157;
                P158 = p158;
                P159 = p159;
                P160 = p160;
                P161 = p161;
                P162 = p162;
                P163 = p163;
                P164 = p164;
                P165 = p165;
                P166 = p166;
                P167 = p167;
                P168 = p168;
                P169 = p169;
                P170 = p170;
                P171 = p171;
                P172 = p172;
                P173 = p173;
                P174 = p174;
                P175 = p175;
                P176 = p176;
                P177 = p177;
                P178 = p178;
                P179 = p179;
                P180 = p180;
                P181 = p181;
                P182 = p182;
                P183 = p183;
                P184 = p184;
                P185 = p185;
                P186 = p186;
                P187 = p187;
                P188 = p188;
                P189 = p189;
                P190 = p190;
                P191 = p191;
                P192 = p192;
                P193 = p193;
                P194 = p194;
                P195 = p195;
                P196 = p196;
                P197 = p197;
                P198 = p198;
                P199 = p199;
                P200 = p200;
                P201 = p201;
                P202 = p202;
                P203 = p203;
                P204 = p204;
                P205 = p205;
                P206 = p206;
                P207 = p207;
                P208 = p208;
                P209 = p209;
                P210 = p210;
                P211 = p211;
                P212 = p212;
                P213 = p213;
                P214 = p214;
                P215 = p215;
                P216 = p216;
                P217 = p217;
                P218 = p218;
                P219 = p219;
                P220 = p220;
                P221 = p221;
                P222 = p222;
                P223 = p223;
                P224 = p224;
                P225 = p225;
                P226 = p226;
                P227 = p227;
                P228 = p228;
                P229 = p229;
                P230 = p230;
                P231 = p231;
                P232 = p232;
                P233 = p233;
                P234 = p234;
                P235 = p235;
                P236 = p236;
                P237 = p237;
                P238 = p238;
                P239 = p239;
                P240 = p240;
                P241 = p241;
                P242 = p242;
                P243 = p243;
                P244 = p244;
                P245 = p245;
                P246 = p246;
                P247 = p247;
                P248 = p248;
                P249 = p249;
                P250 = p250;
                P251 = p251;
                P252 = p252;
                P253 = p253;
                P254 = p254;
            }

            public int P0 { get; }
            public int P1 { get; }
            public int P2 { get; }
            public int P3 { get; }
            public int P4 { get; }
            public int P5 { get; }
            public int P6 { get; }
            public int P7 { get; }
            public int P8 { get; }
            public int P9 { get; }
            public int P10 { get; }
            public int P11 { get; }
            public int P12 { get; }
            public int P13 { get; }
            public int P14 { get; }
            public int P15 { get; }
            public int P16 { get; }
            public int P17 { get; }
            public int P18 { get; }
            public int P19 { get; }
            public int P20 { get; }
            public int P21 { get; }
            public int P22 { get; }
            public int P23 { get; }
            public int P24 { get; }
            public int P25 { get; }
            public int P26 { get; }
            public int P27 { get; }
            public int P28 { get; }
            public int P29 { get; }
            public int P30 { get; }
            public int P31 { get; }
            public int P32 { get; }
            public int P33 { get; }
            public int P34 { get; }
            public int P35 { get; }
            public int P36 { get; }
            public int P37 { get; }
            public int P38 { get; }
            public int P39 { get; }
            public int P40 { get; }
            public int P41 { get; }
            public int P42 { get; }
            public int P43 { get; }
            public int P44 { get; }
            public int P45 { get; }
            public int P46 { get; }
            public int P47 { get; }
            public int P48 { get; }
            public int P49 { get; }
            public int P50 { get; }
            public int P51 { get; }
            public int P52 { get; }
            public int P53 { get; }
            public int P54 { get; }
            public int P55 { get; }
            public int P56 { get; }
            public int P57 { get; }
            public int P58 { get; }
            public int P59 { get; }
            public int P60 { get; }
            public int P61 { get; }
            public int P62 { get; }
            public int P63 { get; }
            public int P64 { get; }
            public int P65 { get; }
            public int P66 { get; }
            public int P67 { get; }
            public int P68 { get; }
            public int P69 { get; }
            public int P70 { get; }
            public int P71 { get; }
            public int P72 { get; }
            public int P73 { get; }
            public int P74 { get; }
            public int P75 { get; }
            public int P76 { get; }
            public int P77 { get; }
            public int P78 { get; }
            public int P79 { get; }
            public int P80 { get; }
            public int P81 { get; }
            public int P82 { get; }
            public int P83 { get; }
            public int P84 { get; }
            public int P85 { get; }
            public int P86 { get; }
            public int P87 { get; }
            public int P88 { get; }
            public int P89 { get; }
            public int P90 { get; }
            public int P91 { get; }
            public int P92 { get; }
            public int P93 { get; }
            public int P94 { get; }
            public int P95 { get; }
            public int P96 { get; }
            public int P97 { get; }
            public int P98 { get; }
            public int P99 { get; }
            public int P100 { get; }
            public int P101 { get; }
            public int P102 { get; }
            public int P103 { get; }
            public int P104 { get; }
            public int P105 { get; }
            public int P106 { get; }
            public int P107 { get; }
            public int P108 { get; }
            public int P109 { get; }
            public int P110 { get; }
            public int P111 { get; }
            public int P112 { get; }
            public int P113 { get; }
            public int P114 { get; }
            public int P115 { get; }
            public int P116 { get; }
            public int P117 { get; }
            public int P118 { get; }
            public int P119 { get; }
            public int P120 { get; }
            public int P121 { get; }
            public int P122 { get; }
            public int P123 { get; }
            public int P124 { get; }
            public int P125 { get; }
            public int P126 { get; }
            public int P127 { get; }
            public int P128 { get; }
            public int P129 { get; }
            public int P130 { get; }
            public int P131 { get; }
            public int P132 { get; }
            public int P133 { get; }
            public int P134 { get; }
            public int P135 { get; }
            public int P136 { get; }
            public int P137 { get; }
            public int P138 { get; }
            public int P139 { get; }
            public int P140 { get; }
            public int P141 { get; }
            public int P142 { get; }
            public int P143 { get; }
            public int P144 { get; }
            public int P145 { get; }
            public int P146 { get; }
            public int P147 { get; }
            public int P148 { get; }
            public int P149 { get; }
            public int P150 { get; }
            public int P151 { get; }
            public int P152 { get; }
            public int P153 { get; }
            public int P154 { get; }
            public int P155 { get; }
            public int P156 { get; }
            public int P157 { get; }
            public int P158 { get; }
            public int P159 { get; }
            public int P160 { get; }
            public int P161 { get; }
            public int P162 { get; }
            public int P163 { get; }
            public int P164 { get; }
            public int P165 { get; }
            public int P166 { get; }
            public int P167 { get; }
            public int P168 { get; }
            public int P169 { get; }
            public int P170 { get; }
            public int P171 { get; }
            public int P172 { get; }
            public int P173 { get; }
            public int P174 { get; }
            public int P175 { get; }
            public int P176 { get; }
            public int P177 { get; }
            public int P178 { get; }
            public int P179 { get; }
            public int P180 { get; }
            public int P181 { get; }
            public int P182 { get; }
            public int P183 { get; }
            public int P184 { get; }
            public int P185 { get; }
            public int P186 { get; }
            public int P187 { get; }
            public int P188 { get; }
            public int P189 { get; }
            public int P190 { get; }
            public int P191 { get; }
            public int P192 { get; }
            public int P193 { get; }
            public int P194 { get; }
            public int P195 { get; }
            public int P196 { get; }
            public int P197 { get; }
            public int P198 { get; }
            public int P199 { get; }
            public int P200 { get; }
            public int P201 { get; }
            public int P202 { get; }
            public int P203 { get; }
            public int P204 { get; }
            public int P205 { get; }
            public int P206 { get; }
            public int P207 { get; }
            public int P208 { get; }
            public int P209 { get; }
            public int P210 { get; }
            public int P211 { get; }
            public int P212 { get; }
            public int P213 { get; }
            public int P214 { get; }
            public int P215 { get; }
            public int P216 { get; }
            public int P217 { get; }
            public int P218 { get; }
            public int P219 { get; }
            public int P220 { get; }
            public int P221 { get; }
            public int P222 { get; }
            public int P223 { get; }
            public int P224 { get; }
            public int P225 { get; }
            public int P226 { get; }
            public int P227 { get; }
            public int P228 { get; }
            public int P229 { get; }
            public int P230 { get; }
            public int P231 { get; }
            public int P232 { get; }
            public int P233 { get; }
            public int P234 { get; }
            public int P235 { get; }
            public int P236 { get; }
            public int P237 { get; }
            public int P238 { get; }
            public int P239 { get; }
            public int P240 { get; }
            public int P241 { get; }
            public int P242 { get; }
            public int P243 { get; }
            public int P244 { get; }
            public int P245 { get; }
            public int P246 { get; }
            public int P247 { get; }
            public int P248 { get; }
            public int P249 { get; }
            public int P250 { get; }
            public int P251 { get; }
            public int P252 { get; }
            public int P253 { get; }
            public int P254 { get; }
        }
    }
}
