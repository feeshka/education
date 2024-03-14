#!/usr/bin/python3
class TextFileCreator:
    @staticmethod
    def create_text_file() -> None:
        print("File creating started")
        
        file = open('/usr/app/text-file.txt', 'w')
        stringForInterpolation = 'INTERPOLATING'
        file.writelines([
            'first line\n',
            'second line\n',
            '\n',
            f'this string for {stringForInterpolation}\n'])
        file.close()
        print("File creating finished")
        
TextFileCreator.create_text_file()