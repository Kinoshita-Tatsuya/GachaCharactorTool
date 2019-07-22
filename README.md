## GachaToolについて

ガチャから出てくるキャラクターの値を設定できるツールにしました。

頑張ったところは、DataGridViewが追加されているかをチェックし、増えていたら増えた分だけInsertを発行しているところです。

## DDL

CREATE `gachasimulator`;
USE `gachasimulator`;
CREATE TABLE `gachtable` (
  `ID` INT NOT NULL,
  `CharactorName` VARCHAR(255) NOT NULL,
  `Probability` FLOAT NOT NULL,
  `Rarity` INT NOT NULL,
  `Image` VARCHAR(255) NULL,
  PRIMARY KEY (`ID`));
