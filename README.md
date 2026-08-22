# VideoRental

C# Windows Forms와 SQL Server를 활용하여 제작한 비디오 대여 관리 프로그램입니다.  
고객, 비디오, 대여 정보를 관리하고 데이터베이스 설계 및 Stored Procedure를 적용한 프로젝트입니다.

## 개발 환경

- Language: C#
- Framework: Windows Forms
- Database: SQL Server
- Data Access: ADO.NET
- IDE: Visual Studio 2022
- DB Tool: SQL Server Management Studio

## 주요 기능

- 고객 정보 등록, 수정, 삭제 및 조회
- 비디오 정보 등록, 수정, 삭제 및 조회
- 비디오 대여 및 반납 관리
- 대여 정보 조회
- 장르 및 고객 유형 기반 필터링
- 대여기간, 대여료, 연체료 환경 설정
- 대여 현황 CSV 출력

## 데이터베이스

비디오 대여 프로그램에서 필요한 데이터를 다음과 같이 분리하여 관리했습니다.

- CustomerTable
- VideoTable
- RentalTable
- SettingTable

데이터 중복을 줄이고 관리하기 쉽도록 정규화를 진행하고 테이블 간 관계를 설계했습니다.

## 구현 내용

### Stored Procedure

반복적으로 사용되는 고객 및 비디오 CRUD 기능과 대여 관련 조회 기능을 Stored Procedure로 분리하여 구현했습니다.

### Index

고객명, 비디오 제목, 장르, 대여일 등 조회에 자주 사용되는 컬럼에 인덱스를 적용했습니다.

### ADO.NET

C# Windows Forms 애플리케이션에서 ADO.NET을 사용하여 SQL Server와 연결하고 데이터를 조회, 등록, 수정, 삭제하도록 구현했습니다.

## 프로젝트 구조

```text
VideoRental/
├── VideoRental/
│   ├── formCustomer.cs
│   ├── formVideoInfo.cs
│   ├── formVideoRental.cs
│   ├── formVideoRentalManage.cs
│   ├── formVideoRentalSetting.cs
│   └── ...
├── VideoRental.sql
└── proc 저장.txt
