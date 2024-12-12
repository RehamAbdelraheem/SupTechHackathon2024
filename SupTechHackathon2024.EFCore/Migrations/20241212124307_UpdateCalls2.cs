using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupTechHackathon2024.EFCore.Migrations
{
    public partial class UpdateCalls2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("11865050-eb7b-4db3-a9ca-e52a6ab90425"), 2, 5, "000010649257", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 14, 43, 6, 860, DateTimeKind.Local).AddTicks(4647), null, null, null, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 14, 39, 6, 860, DateTimeKind.Local).AddTicks(4645), 0, "ألو، مساء الخير. أنا من بنك الإسكندرية، عندنا عرض تمويل جديد للشركات الزراعية.\nمساء النور، اتفضل.\nالعرض ده بفائدة منخفضة وممكن يساعدك في تطوير المزارع وزيادة الإنتاج.\nالعرض ده كويس، بس بصراحة الميزانية الحالية مش هتسمح لنا نتحمل أي قروض جديدة دلوقتي.\nما تقلقش، إحنا هنساعدك في ترتيب خطة دفع مريحة حتى لو مش هتقدر تلتزم بيها دلوقتي.\nطيب، ممكن نتكلم في التفاصيل أكتر، بس مش متأكد إني هقدر ألتزم دلوقتي.\nما فيش مشكلة، المهم إنك تبدأ وتستفيد من العرض." },
                    { new Guid("3c357718-ef56-47b8-bce3-abd3b324d109"), 4, 2, "000010649254", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 14, 43, 6, 860, DateTimeKind.Local).AddTicks(4668), null, null, null, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 14, 39, 6, 860, DateTimeKind.Local).AddTicks(4667), 0, "ألو، مساء الخير. أنا من بنك مصر، عندنا عرض جديد لقرض شخصي بفائدة منخفضة.\nمساء النور، اتفضل.\nالقرض ده ممكن يساعدك في تغطية مصاريفك الشخصية أو أي احتياجات طارئة.\nالعرض ده كويس، بس بصراحة الميزانية الحالية مش هتسمح لي أتحمل أي قروض جديدة دلوقتي.\nما تقلقش، إحنا هنساعدك في ترتيب خطة دفع مريحة حتى لو مش هتقدر تلتزم بيها دلوقتي.\nطيب، ممكن نتكلم في التفاصيل أكتر، بس مش متأكد إني هقدر ألتزم دلوقتي.\nما فيش مشكلة، المهم إنك تبدأ وتستفيد من العرض." },
                    { new Guid("3c5919bb-e1cc-44b9-b58d-0049cc5e7612"), 2, 5, "000010649257", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 14, 43, 6, 860, DateTimeKind.Local).AddTicks(4659), null, null, null, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 14, 39, 6, 860, DateTimeKind.Local).AddTicks(4658), 0, "ألو، مساء الخير. أنا من بنك الإسكندرية، عندنا عرض تمويل جديد للشركات الزراعية.\nمساء النور، بس بصراحة مش مهتمين بأي تمويل جديد دلوقتي.\nالعرض ده بفائدة منخفضة وممكن يساعدك في تطوير المزارع.\nحتى لو الفائدة منخفضة، إحنا مش في وضع يسمح لنا نتحمل أي قروض جديدة دلوقتي.\nفاهم، لو احتجت أي مساعدة في المستقبل، إحنا موجودين." },
                    { new Guid("48d86a90-de73-472a-b6e7-7087f0a3d189"), 1, 3, "000010649258", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 14, 43, 6, 860, DateTimeKind.Local).AddTicks(4643), null, null, null, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 14, 39, 6, 860, DateTimeKind.Local).AddTicks(4642), 0, "ألو، مساء الخير. أنا من بنك القاهرة، عندنا عرض تمويل جديد للشركات الصغيرة والمتوسطة.\nمساء النور، بس بصراحة مش مهتمين بأي تمويل جديد دلوقتي.\nالعرض ده بفائدة منخفضة وممكن يساعدك في توسعات شركتك.\nحتى لو الفائدة منخفضة، إحنا مش في وضع يسمح لنا نتحمل أي قروض جديدة دلوقتي.\nفاهم، لو احتجت أي مساعدة في المستقبل، إحنا موجودين." },
                    { new Guid("8a4b7b5f-94a0-4e6f-970b-056103ae6e2a"), 3, 1, "000010649255", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 14, 43, 6, 860, DateTimeKind.Local).AddTicks(4665), null, null, null, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 14, 39, 6, 860, DateTimeKind.Local).AddTicks(4664), 0, "ألو، مساء الخير. أنا من البنك الأهلي المصري، عندنا عرض جديد لبطاقة ائتمان بفائدة منخفضة.\nمساء النور، بس بصراحة مش مهتمة ببطاقات ائتمان جديدة دلوقتي.\nالبطاقة دي ممكن تساعدك في إدارة مصاريفك اليومية وتوفر لك عروض وخصومات حصرية.\nحتى لو الفائدة منخفضة، أنا مش محتاجة بطاقة جديدة دلوقتي.\nلازم تاخدي البطاقة دي، هتساعدك كتير في مصاريفك.\nقلت لحضرتك مش مهتمة، شكراً." },
                    { new Guid("accd246e-f6fc-477d-ae37-9bb5fa351d0f"), 3, 1, "000010649255", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 14, 43, 6, 860, DateTimeKind.Local).AddTicks(4662), null, null, null, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 14, 39, 6, 860, DateTimeKind.Local).AddTicks(4661), 0, "ألو، مساء الخير. أنا من البنك الأهلي المصري، عندنا عرض جديد لبطاقة ائتمان بفائدة منخفضة.\nمساء النور، اتفضل.\nالبطاقة دي ممكن تساعدك في إدارة مصاريفك اليومية وتوفر لك عروض وخصومات حصرية.\nالعرض ده كويس، أنا مهتمة. إيه الإجراءات المطلوبة؟\nهنحتاج بعض الأوراق البسيطة، وممكن نبدأ في الإجراءات فورًا.\nتمام، هجهز الأوراق وأبعتهم لحضرتك." },
                    { new Guid("c48ff439-3fe0-4b5a-a9fe-49f594d87e93"), 4, 2, "000010649254", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 14, 43, 6, 860, DateTimeKind.Local).AddTicks(4671), null, null, null, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 14, 39, 6, 860, DateTimeKind.Local).AddTicks(4670), 0, "ألو، مساء الخير. أنا من بنك مصر، عندنا عرض جديد لقرض شخصي بفائدة منخفضة.\nمساء النور، بس بصراحة مش مهتم بأي قروض جديدة دلوقتي.\nالقرض ده ممكن يساعدك في تغطية مصاريفك الشخصية أو أي احتياجات طارئة.\nحتى لو الفائدة منخفضة، أنا مش في وضع يسمح لي أتحمل أي قروض جديدة دلوقتي.\nفاهم، لو احتجت أي مساعدة في المستقبل، إحنا موجودين." },
                    { new Guid("e5722ef2-d366-47f9-8605-e5ec16ff8e1f"), 1, 3, "000010649258", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 14, 43, 6, 860, DateTimeKind.Local).AddTicks(4638), null, null, null, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 14, 39, 6, 860, DateTimeKind.Local).AddTicks(4602), 0, "ألو، مساء الخير. أنا من بنك القاهرة، ممكن أتكلم مع حضرتك عن عرض التمويل الجديد للشركات الصغيرة والمتوسطة؟\nمساء النور، اتفضل.\nعندنا عرض تمويل بفائدة منخفضة لتمويل توسعات شركتك. العرض ده ممكن يساعدك في تطوير البنية التحتية وزيادة الإنتاج.\nالعرض ده ممتاز، بس بصراحة الميزانية الحالية مش هتسمح لنا نتحمل أي قروض جديدة دلوقتي.\nما تقلقش، إحنا هنساعدك في ترتيب خطة دفع مريحة حتى لو مش هتقدر تلتزم بيها دلوقتي.\nطيب، ممكن نتكلم في التفاصيل أكتر، بس مش متأكد إني هقدر ألتزم دلوقتي.\nما فيش مشكلة، المهم إنك تبدأ وتستفيد من العرض." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("11865050-eb7b-4db3-a9ca-e52a6ab90425"));

            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("3c357718-ef56-47b8-bce3-abd3b324d109"));

            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("3c5919bb-e1cc-44b9-b58d-0049cc5e7612"));

            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("48d86a90-de73-472a-b6e7-7087f0a3d189"));

            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("8a4b7b5f-94a0-4e6f-970b-056103ae6e2a"));

            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("accd246e-f6fc-477d-ae37-9bb5fa351d0f"));

            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("c48ff439-3fe0-4b5a-a9fe-49f594d87e93"));

            migrationBuilder.DeleteData(
                table: "Call",
                keyColumn: "Id",
                keyValue: new Guid("e5722ef2-d366-47f9-8605-e5ec16ff8e1f"));

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
    }
}
