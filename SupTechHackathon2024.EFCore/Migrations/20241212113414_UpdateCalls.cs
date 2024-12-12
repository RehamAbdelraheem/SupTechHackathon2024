using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupTechHackathon2024.EFCore.Migrations
{
    public partial class UpdateCalls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("13335d0c-5011-49d0-9d47-0ff799e2a5a1"));

            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("1de2cbb9-5afd-4881-8f9a-5976cd9a1ca6"));

            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("68d1ba0a-4979-4083-94c6-232857c0d07f"));

            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("b4e778f4-bf7c-4c27-b034-3fb6c6c18bd1"));

            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("c448cbae-f434-47b5-b9d4-eae911c151d4"));

            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("d9a0d701-f3e7-4c27-9e3b-051f67b2f1f1"));

            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("e20f0191-5e18-4362-871b-7bc40f435fb2"));

            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("ecff67c3-a4aa-4480-a2f6-409501d6f7db"));

            migrationBuilder.InsertData(
                table: "Call",
                columns: new[] { "Id", "BankBranchId", "BankId", "CbeCustomerId", "CreateBy", "CreateDate", "EndTime", "FinancialServiceId", "IsAiAnalysisFailed", "IsMisSellingDetected", "MisSellingCategoryId", "ModifiedBy", "ModifiedDate", "StartTime", "Status", "Transcript" },
                values: new object[,]
                {
                    { new Guid("2838a41c-afdc-428f-8886-e5706fc4ff4f"), 4, 2, "000010649254", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true, false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من بنك مصر، عندنا عرض جديد لقرض شخصي بفائدة منخفضة.\nمساء النور، بس بصراحة مش مهتم بأي قروض جديدة دلوقتي.\nالقرض ده ممكن يساعدك في تغطية مصاريفك الشخصية أو أي احتياجات طارئة.\nحتى لو الفائدة منخفضة، أنا مش في وضع يسمح لي أتحمل أي قروض جديدة دلوقتي.\nفاهم، لو احتجت أي مساعدة في المستقبل، إحنا موجودين." },
                    { new Guid("28bb154c-2670-4a01-b8d8-336a4d6a24b8"), 3, 1, "000010649255", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true, true, 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من البنك الأهلي المصري، عندنا عرض جديد لبطاقة ائتمان بفائدة منخفضة.\nمساء النور، بس بصراحة مش مهتمة ببطاقات ائتمان جديدة دلوقتي.\nالبطاقة دي ممكن تساعدك في إدارة مصاريفك اليومية وتوفر لك عروض وخصومات حصرية.\nحتى لو الفائدة منخفضة، أنا مش محتاجة بطاقة جديدة دلوقتي.\nلازم تاخدي البطاقة دي، هتساعدك كتير في مصاريفك.\nقلت لحضرتك مش مهتمة، شكراً." },
                    { new Guid("48faf0e9-563f-4270-9d11-3c98963a7cbd"), 2, 5, "000010649257", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من بنك الإسكندرية، عندنا عرض تمويل جديد للشركات الزراعية.\nمساء النور، بس بصراحة مش مهتمين بأي تمويل جديد دلوقتي.\nالعرض ده بفائدة منخفضة وممكن يساعدك في تطوير المزارع.\nحتى لو الفائدة منخفضة، إحنا مش في وضع يسمح لنا نتحمل أي قروض جديدة دلوقتي.\nفاهم، لو احتجت أي مساعدة في المستقبل، إحنا موجودين." },
                    { new Guid("68977fba-e51e-4bd2-94cc-c45a0e35acfe"), 1, 3, "000010649258", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, true, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من بنك القاهرة، ممكن أتكلم مع حضرتك عن عرض التمويل الجديد للشركات الصغيرة والمتوسطة؟\nمساء النور، اتفضل.\nعندنا عرض تمويل بفائدة منخفضة لتمويل توسعات شركتك. العرض ده ممكن يساعدك في تطوير البنية التحتية وزيادة الإنتاج.\nالعرض ده ممتاز، بس بصراحة الميزانية الحالية مش هتسمح لنا نتحمل أي قروض جديدة دلوقتي.\nما تقلقش، إحنا هنساعدك في ترتيب خطة دفع مريحة حتى لو مش هتقدر تلتزم بيها دلوقتي.\nطيب، ممكن نتكلم في التفاصيل أكتر، بس مش متأكد إني هقدر ألتزم دلوقتي.\nما فيش مشكلة، المهم إنك تبدأ وتستفيد من العرض." },
                    { new Guid("795b3d80-952b-4af2-91ee-35f93f3ce2d7"), 4, 2, "000010649254", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true, true, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من بنك مصر، عندنا عرض جديد لقرض شخصي بفائدة منخفضة.\nمساء النور، اتفضل.\nالقرض ده ممكن يساعدك في تغطية مصاريفك الشخصية أو أي احتياجات طارئة.\nالعرض ده كويس، بس بصراحة الميزانية الحالية مش هتسمح لي أتحمل أي قروض جديدة دلوقتي.\nما تقلقش، إحنا هنساعدك في ترتيب خطة دفع مريحة حتى لو مش هتقدر تلتزم بيها دلوقتي.\nطيب، ممكن نتكلم في التفاصيل أكتر، بس مش متأكد إني هقدر ألتزم دلوقتي.\nما فيش مشكلة، المهم إنك تبدأ وتستفيد من العرض." },
                    { new Guid("c10066cb-7980-429d-b359-69b7d33dee01"), 1, 3, "000010649258", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من بنك القاهرة، عندنا عرض تمويل جديد للشركات الصغيرة والمتوسطة.\nمساء النور، بس بصراحة مش مهتمين بأي تمويل جديد دلوقتي.\nالعرض ده بفائدة منخفضة وممكن يساعدك في توسعات شركتك.\nحتى لو الفائدة منخفضة، إحنا مش في وضع يسمح لنا نتحمل أي قروض جديدة دلوقتي.\nفاهم، لو احتجت أي مساعدة في المستقبل، إحنا موجودين." },
                    { new Guid("c6652b6d-4753-4c83-aecb-4298b31265d1"), 2, 5, "000010649257", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, true, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من بنك الإسكندرية، عندنا عرض تمويل جديد للشركات الزراعية.\nمساء النور، اتفضل.\nالعرض ده بفائدة منخفضة وممكن يساعدك في تطوير المزارع وزيادة الإنتاج.\nالعرض ده كويس، بس بصراحة الميزانية الحالية مش هتسمح لنا نتحمل أي قروض جديدة دلوقتي.\nما تقلقش، إحنا هنساعدك في ترتيب خطة دفع مريحة حتى لو مش هتقدر تلتزم بيها دلوقتي.\nطيب، ممكن نتكلم في التفاصيل أكتر، بس مش متأكد إني هقدر ألتزم دلوقتي.\nما فيش مشكلة، المهم إنك تبدأ وتستفيد من العرض." },
                    { new Guid("e96fc4f2-e334-483e-b915-a81dbca91132"), 3, 1, "000010649255", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من البنك الأهلي المصري، عندنا عرض جديد لبطاقة ائتمان بفائدة منخفضة.\nمساء النور، اتفضل.\nالبطاقة دي ممكن تساعدك في إدارة مصاريفك اليومية وتوفر لك عروض وخصومات حصرية.\nالعرض ده كويس، أنا مهتمة. إيه الإجراءات المطلوبة؟\nهنحتاج بعض الأوراق البسيطة، وممكن نبدأ في الإجراءات فورًا.\nتمام، هجهز الأوراق وأبعتهم لحضرتك." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("2838a41c-afdc-428f-8886-e5706fc4ff4f"));

            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("28bb154c-2670-4a01-b8d8-336a4d6a24b8"));

            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("48faf0e9-563f-4270-9d11-3c98963a7cbd"));

            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("68977fba-e51e-4bd2-94cc-c45a0e35acfe"));

            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("795b3d80-952b-4af2-91ee-35f93f3ce2d7"));

            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("c10066cb-7980-429d-b359-69b7d33dee01"));

            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("c6652b6d-4753-4c83-aecb-4298b31265d1"));

            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("e96fc4f2-e334-483e-b915-a81dbca91132"));

            migrationBuilder.InsertData(
                table: "Call",
                columns: new[] { "Id", "BankBranchId", "BankId", "CbeCustomerId", "CreateBy", "CreateDate", "EndTime", "FinancialServiceId", "IsAiAnalysisFailed", "IsMisSellingDetected", "MisSellingCategoryId", "ModifiedBy", "ModifiedDate", "StartTime", "Status", "Transcript" },
                values: new object[,]
                {
                    { new Guid("13335d0c-5011-49d0-9d47-0ff799e2a5a1"), 3, 1, "000010649255", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من البنك الأهلي المصري، عندنا عرض جديد لبطاقة ائتمان بفائدة منخفضة.\nمساء النور، اتفضل.\nالبطاقة دي ممكن تساعدك في إدارة مصاريفك اليومية وتوفر لك عروض وخصومات حصرية.\nالعرض ده كويس، أنا مهتمة. إيه الإجراءات المطلوبة؟\nهنحتاج بعض الأوراق البسيطة، وممكن نبدأ في الإجراءات فورًا.\nتمام، هجهز الأوراق وأبعتهم لحضرتك." },
                    { new Guid("1de2cbb9-5afd-4881-8f9a-5976cd9a1ca6"), 4, 2, "000010649254", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, true, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من بنك مصر، عندنا عرض جديد لقرض شخصي بفائدة منخفضة.\nمساء النور، اتفضل.\nالقرض ده ممكن يساعدك في تغطية مصاريفك الشخصية أو أي احتياجات طارئة.\nالعرض ده كويس، بس بصراحة الميزانية الحالية مش هتسمح لي أتحمل أي قروض جديدة دلوقتي.\nما تقلقش، إحنا هنساعدك في ترتيب خطة دفع مريحة حتى لو مش هتقدر تلتزم بيها دلوقتي.\nطيب، ممكن نتكلم في التفاصيل أكتر، بس مش متأكد إني هقدر ألتزم دلوقتي.\nما فيش مشكلة، المهم إنك تبدأ وتستفيد من العرض." },
                    { new Guid("68d1ba0a-4979-4083-94c6-232857c0d07f"), 1, 3, "000010649258", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, true, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من بنك القاهرة، ممكن أتكلم مع حضرتك عن عرض التمويل الجديد للشركات الصغيرة والمتوسطة؟\nمساء النور، اتفضل.\nعندنا عرض تمويل بفائدة منخفضة لتمويل توسعات شركتك. العرض ده ممكن يساعدك في تطوير البنية التحتية وزيادة الإنتاج.\nالعرض ده ممتاز، بس بصراحة الميزانية الحالية مش هتسمح لنا نتحمل أي قروض جديدة دلوقتي.\nما تقلقش، إحنا هنساعدك في ترتيب خطة دفع مريحة حتى لو مش هتقدر تلتزم بيها دلوقتي.\nطيب، ممكن نتكلم في التفاصيل أكتر، بس مش متأكد إني هقدر ألتزم دلوقتي.\nما فيش مشكلة، المهم إنك تبدأ وتستفيد من العرض." },
                    { new Guid("b4e778f4-bf7c-4c27-b034-3fb6c6c18bd1"), 1, 3, "000010649258", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من بنك القاهرة، عندنا عرض تمويل جديد للشركات الصغيرة والمتوسطة.\nمساء النور، بس بصراحة مش مهتمين بأي تمويل جديد دلوقتي.\nالعرض ده بفائدة منخفضة وممكن يساعدك في توسعات شركتك.\nحتى لو الفائدة منخفضة، إحنا مش في وضع يسمح لنا نتحمل أي قروض جديدة دلوقتي.\nفاهم، لو احتجت أي مساعدة في المستقبل، إحنا موجودين." },
                    { new Guid("c448cbae-f434-47b5-b9d4-eae911c151d4"), 3, 1, "000010649255", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, true, 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من البنك الأهلي المصري، عندنا عرض جديد لبطاقة ائتمان بفائدة منخفضة.\nمساء النور، بس بصراحة مش مهتمة ببطاقات ائتمان جديدة دلوقتي.\nالبطاقة دي ممكن تساعدك في إدارة مصاريفك اليومية وتوفر لك عروض وخصومات حصرية.\nحتى لو الفائدة منخفضة، أنا مش محتاجة بطاقة جديدة دلوقتي.\nلازم تاخدي البطاقة دي، هتساعدك كتير في مصاريفك.\nقلت لحضرتك مش مهتمة، شكراً." },
                    { new Guid("d9a0d701-f3e7-4c27-9e3b-051f67b2f1f1"), 4, 2, "000010649254", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من بنك مصر، عندنا عرض جديد لقرض شخصي بفائدة منخفضة.\nمساء النور، بس بصراحة مش مهتم بأي قروض جديدة دلوقتي.\nالقرض ده ممكن يساعدك في تغطية مصاريفك الشخصية أو أي احتياجات طارئة.\nحتى لو الفائدة منخفضة، أنا مش في وضع يسمح لي أتحمل أي قروض جديدة دلوقتي.\nفاهم، لو احتجت أي مساعدة في المستقبل، إحنا موجودين." },
                    { new Guid("e20f0191-5e18-4362-871b-7bc40f435fb2"), 2, 5, "000010649257", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, true, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من بنك الإسكندرية، عندنا عرض تمويل جديد للشركات الزراعية.\nمساء النور، اتفضل.\nالعرض ده بفائدة منخفضة وممكن يساعدك في تطوير المزارع وزيادة الإنتاج.\nالعرض ده كويس، بس بصراحة الميزانية الحالية مش هتسمح لنا نتحمل أي قروض جديدة دلوقتي.\nما تقلقش، إحنا هنساعدك في ترتيب خطة دفع مريحة حتى لو مش هتقدر تلتزم بيها دلوقتي.\nطيب، ممكن نتكلم في التفاصيل أكتر، بس مش متأكد إني هقدر ألتزم دلوقتي.\nما فيش مشكلة، المهم إنك تبدأ وتستفيد من العرض." },
                    { new Guid("ecff67c3-a4aa-4480-a2f6-409501d6f7db"), 2, 5, "000010649257", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من بنك الإسكندرية، عندنا عرض تمويل جديد للشركات الزراعية.\nمساء النور، بس بصراحة مش مهتمين بأي تمويل جديد دلوقتي.\nالعرض ده بفائدة منخفضة وممكن يساعدك في تطوير المزارع.\nحتى لو الفائدة منخفضة، إحنا مش في وضع يسمح لنا نتحمل أي قروض جديدة دلوقتي.\nفاهم، لو احتجت أي مساعدة في المستقبل، إحنا موجودين." }
                });
        }
    }
}
