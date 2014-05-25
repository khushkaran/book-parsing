require "spec_helper"
require "book_parser"

describe BookParser do

  let(:parser) { BookParser.new("../text.txt")}
  let(:string) { "This is simples! This will be fun!" }

  it "can be initialised with text file" do
    expect(parser.book).not_to be_nil
  end

  context "Splitting a string" do

    let(:split_string) { ["This", "is", "simples", "This", "will", "be", "fun"] }

    it "can split a string" do
      expect(parser.split(string)).to eq split_string
    end

    it "can count the occurences of words" do
      occurences = {"This"=>2, "Is"=>1, "Simples"=>1, "Will"=>1, "Be"=>1, "Fun"=>1}
      expect(parser.occurences(split_string)).to eq occurences
    end

    it "replaces new lines with spaces" do
      another_string = "This is simples! This will be fun!\nThis is simples! This will be fun!"
      another_split_string = ["This", "is", "simples", "This", "will", "be", "fun", "This", "is", "simples", "This", "will", "be", "fun"]
      occurences = {"This"=>4, "Is"=>2, "Simples"=>2, "Will"=>2, "Be"=>2, "Fun"=>2}
      expect(parser.split(another_string)).to eq another_split_string
      expect(parser.occurences(another_split_string)).to eq occurences
    end
  end

  it "can produce a report on the text file" do
    parser.book = string
    expect(parser.report).to eq "Word  |  Number of Words\nThis  |  2\nIs  |  1\nSimples  |  1\nWill  |  1\nBe  |  1\nFun  |  1"
  end
  
end